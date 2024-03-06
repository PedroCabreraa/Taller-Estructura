using System.Collections;
using Microsoft.VisualBasic;

namespace TallerEstructura4{

    public class Doctor{
        string nombre;
        string especialidad;

        public string Nombre{
            get { return nombre; }
        }

        public void VerNombre(string nombre){
            this.nombre=nombre;
        }

        public string Especialidad{
            get { return especialidad; }
        }

        public void VerEspecialidad(string especialidad){
            this.especialidad=especialidad;
        }

    }
}