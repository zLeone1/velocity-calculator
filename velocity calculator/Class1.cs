using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace velocity_calculator
{
    public class FinalVelocityCalculator
    {
        private double initialVelocity;        
        private double acceleration;
        private double time;

        public FinalVelocityCalculator(double initialVelocity, double acceleration, double time)
        {
            this.initialVelocity = initialVelocity;
            this.acceleration = acceleration;
            this.time = time;
        }

        public double CalculateFinalVelocity()
        {
            return initialVelocity + (acceleration * time);
        }
    }
}
