﻿using System.Windows.Media.Media3D;
using Microsoft.Kinect;

namespace KinectFittingRoom.Model.ClothingItems
{
    class SkirtItem : ClothingItemBase
    {
        /// <summary>
        /// Hips width with margins
        /// </summary>
        private const double Ratio = 0.9;
        #region .ctor
        /// <summary>
        /// Constructor of Skirt object
        /// </summary>
        /// <param name="model">3D model</param>
        public SkirtItem(Model3DGroup model)
            : base(model, Ratio)
        {
            JointToTrackPosition = JointType.HipCenter;
            LeftJointToTrackAngle = JointType.HipLeft;
            RightJointToTrackAngle = JointType.HipRight;
            LeftJointToTrackScale = JointType.HipCenter;
            RightJointToTrackScale = JointType.KneeRight;
        }
        #endregion .ctor
    }
}