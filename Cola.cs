using System.Collections;
using Microsoft.VisualBasic;
using TallerEstructura2;

namespace TallerEstructura{

    public class Cola{
        int max;
        Paciente []pacientes;
        int fin;
        int inicio;

        public Cola(int max){
            this.max=max;
            pacientes=new Paciente[max];
            inicio=0;
            fin=-1;
        }

        public int VerFin{
            get{return fin;}
        }

        public void Agregar(Paciente x){
            if(Llena()){
                Console.WriteLine("La cola de espera esta llena, no hay espacio en el Hospital");
            }
            else{
                fin=fin+1;
                pacientes[fin]=x;
            }
        }

        public void Atender(Paciente aux){
            if(Vacia()){
                Console.WriteLine("No hay pacientes en espera");
            }
            else{
                aux=pacientes[0];
                for (int j = 0; j != fin; j++){
                    pacientes[j] = pacientes[j + 1];
                }
                fin--;
            }
        }

        public bool Vacia(){
            if(fin==-1){
                return true;
            }
            else{
                return false;
            }
        }
        public bool Llena(){
            if(fin==max) {
                return true;
            }
            else{
                return false;
            }
        }
    }
}