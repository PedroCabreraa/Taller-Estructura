using System.Collections;
using Microsoft.VisualBasic;

namespace TallerEstructura2{

    public class Paciente{
        public string nombre;
        public int edad;
        public int cedula;
        public int motivo;
        public int NA;

        public string VerNombre{
            get { return nombre; }
        }

        public void SetNombre(string nombre){
            this.nombre=nombre;
        }

        public int MostrarEdad{
            get { return edad;}
        }

        public void SetEdad(int edad){
            this.edad=edad;
        }

        public int MostrarCedula{
            get { return cedula;}
        }

        public void SetCedula(int cedula){
            this.cedula=cedula;
        }

        public int VerMotivo{
            get {return motivo;}
        }

        public void SetMotivo(int motivo){
            this.motivo=motivo;
        }

        public int VerNA{
            get {return NA;}
        }

        public void SetNA(int NA){
            this.NA = NA;
        }
    }
}