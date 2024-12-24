using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_2
{
    internal class car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public double Speed { get; set; }
        public car(int _id, string _model, double _speed = 150) {
            Id = _id;
            Model = _model;
            Speed = _speed;
        }
        public car(int _id,string _model):this(_id,_model,150) {
        }
        public car(int _id):this(_id,"Mercedes",150) { }
        public override string ToString()
        {
            return $"Car Data : \nid = {Id}\nmodel = {Model}\nspeed = {Speed}\n";
        }
    }
}
