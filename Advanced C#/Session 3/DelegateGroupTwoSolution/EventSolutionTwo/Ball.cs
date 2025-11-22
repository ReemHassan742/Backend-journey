using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSolutionTwo
{
    class LocationEventArgs : EventArgs
    {
        public Location Location { get; set; }
    }
    //Publisher
    internal class Ball
    {
        public int Id { get; set; }

        public Ball(int id)
        {
            Id = id;
        }
        public override string ToString()
        {
            return $"Ball {Id}";
        }

        private Location location;

        public Location Location
        {
            get { return location; }
            set 
            {
                if (!location.Equals(value))
                {
                    location = value;
                    On_BallChanged(location);
                }
            
            }
        }
        protected virtual void On_BallChanged(Location location)
        {
            OnBallChanged.Invoke(this, new LocationEventArgs { Location = location});
        }
        public event EventHandler<LocationEventArgs> OnBallChanged; // Recommend ==> EventHandler

    }
}
