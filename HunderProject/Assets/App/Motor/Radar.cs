using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Effector
{
    class Radar
    {
        [SerializeField] float tickSpacing_ = 1f;
        [SerializeField] float radius_ = 10f;

        [SerializeField] bool debugVisable_ = false;

        public float Radius
        {
            get { return radius_; }
            set { radius_ = value; }
        }
    }
}