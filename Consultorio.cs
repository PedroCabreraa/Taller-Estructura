using System.Collections;
using Microsoft.VisualBasic;
using TallerEstructura;
using TallerEstructura2;
using TallerEstructura4;

namespace TallerEstructura3{

    public class Consultorio{

        public void menu(Cola N1,Cola N2, Cola N3, Cola N4, Cola N5,Cola A1, Cola A2, Cola A3, Cola A4, Cola A5,Paciente aux){
        int op;
        int flag=-1;
        
        do{
            Console.WriteLine("\t.:Menu:.\n1. Ingresar Paciente\n2. Atender\n3. Reporte\n4. Salir");
            do{
                Console.Write("--> ");
                op=int.Parse(Console.ReadLine());
            }while(op<1||op>4);

            switch(op){
                    case 1: //Codigo para Ingresar
                            Paciente nuevo = new Paciente();
                            RegistrarPaciente(nuevo);
                            if(nuevo.VerNA==1){
                                if(nuevo.VerMotivo==1) { 
                                    A1.Agregar(nuevo);
                                    Console.WriteLine("Se añadió un adulto con accidente aparatoso a la cola de espera\n");
                                }
                                else if(nuevo.VerMotivo==2){
                                    A2.Agregar(nuevo);
                                    Console.WriteLine("Se añadió un adulto con infarto a la cola de espera\n");
                                }
                                else if(nuevo.VerMotivo==3) {
                                    A3.Agregar(nuevo);
                                    Console.WriteLine("Se añadió un adulto con afecciones respiratorias a la cola de espera\n");
                                }
                                else if(nuevo.VerMotivo==4) {
                                    A4.Agregar(nuevo);
                                    Console.WriteLine("Se añadió una mujer en labor de parto a la cola de espera\n");
                                }
                                else{
                                    A5.Agregar(nuevo);
                                    Console.WriteLine("Se añadió un adulto con enfermedad menor a la cola de espera\n");
                                } 
                            }
                            else{
                                if(nuevo.VerMotivo==1) { 
                                    N1.Agregar(nuevo);
                                    Console.WriteLine("Se añadió un niño con accidente aparatoso a la cola de espera\n");
                                }
                                else if(nuevo.VerMotivo==2){
                                    N2.Agregar(nuevo);
                                    Console.WriteLine("Se añadió un niño con infarto a la cola de espera\n");
                                }
                                else if(nuevo.VerMotivo==3) {
                                    N3.Agregar(nuevo);
                                    Console.WriteLine("Se añadió un niño con afecciones respiratorias a la cola de espera\n");
                                }
                                else if(nuevo.VerMotivo==4) {
                                    N4.Agregar(nuevo);
                                    Console.WriteLine("Se añadió una niña en labor de parto a la cola de espera\n");
                                }
                                else{
                                    N5.Agregar(nuevo);
                                    Console.WriteLine("Se añadió un niño con enfermedad menor a la cola de espera\n");
                                } 
                            }
                            
                            break;
                    case 2: //Codigo para Atender
                            Random ran = new Random();
                            int r =ran.Next(1,3);
                            if(r==1){
                                flag=AtenderNiño(N1,N2,N3,N4,N5,flag,aux);
                                if(flag==0){
                                    flag=AtenderAdulto(A1,A2,A3,A4,A5,flag,aux);
                                    if(flag==0){
                                        Console.WriteLine("NO HAY PACIENTES POR ATENDER");
                                    } 
                                }
                            }
                            else{
                                flag=AtenderAdulto(A1,A2,A3,A4,A5,flag,aux);
                                if(flag==0){
                                    flag=AtenderNiño(N1,N2,N3,N4,N5,flag,aux);
                                    if(flag==0){
                                        Console.WriteLine("NO HAY PACIENTES POR ATENDER");
                                    }                                  
                                }
                            }
                            break;
                    case 3: //Codigo para generar Reporte
                            Reporte(N1,N2,N3,N4,N5,A1,A2,A3,A4,A5,aux);
                            break;
                    case 4: //Salir
                            break;
            }

        }while(op!=4);

        Console.WriteLine("GRACIAS POR USAR NUESTRO SISTEMA AUTOMATIZADO HOSPITALARIO\n");
        }
        
        public void RegistrarPaciente(Paciente x){
            Random random = new Random();

            int edad = random.Next(1,81);
            x.SetEdad(edad);

            if(x.edad>15){
                x.SetNA(1);
            }
            else{
                x.SetNA(0);
            }

            int motivo = random.Next(1,6);

            if((x.MostrarEdad<15)&&(motivo==4)){
                while((x.MostrarEdad<15)&&(motivo==4)){
                    motivo = random.Next(1,6);
                }   //COMPROBAR QUE UNA NIÑA MENOR A 15 NO QUEDE EMBARAZADA                
            }

            x.SetMotivo(motivo);
            
            if(motivo==5){
                Console.Write("Nombre: ");
                string nombre= Console.ReadLine();
                x.SetNombre(nombre);
                Console.Write("Cedula: ");
                int cedula = int.Parse(Console.ReadLine());
            }            
        }

        public int AtenderNiño(Cola N1,Cola N2, Cola N3, Cola N4, Cola N5,int flag,Paciente aux){
            flag=0;
            if (N1.Vacia()==false){
                N1.Atender(aux);
                flag=1;
                Console.WriteLine("Se atendió a un niño con accidente aparatoso");
            }
            else if(N2.Vacia()==false){
                N2.Atender(aux);
                flag=1;
                Console.WriteLine("Se atendió a un niño con infarto");
            }
            else if(N3.Vacia()==false){
                N3.Atender(aux);
                flag=1;
                Console.WriteLine("Se atendió a un niño con afecciones respiratorias");
            }
            else if(N4.Vacia()==false){
                N4.Atender(aux);
                flag=1;
                Console.WriteLine("Se atendió a una niña en labor de parto");
            }
            else if(N5.Vacia()==false){
                N5.Atender(aux);
                flag=1;
                Console.WriteLine("Se atendió a un niño con enfermedad menor");
            }
            return flag;
        }

        public int AtenderAdulto(Cola A1, Cola A2, Cola A3, Cola A4, Cola A5,int flag,Paciente aux){
            flag=0;

            if (A1.Vacia()==false){
                A1.Atender(aux);
                flag=1;
                Console.WriteLine("Se atendió a un adulto con accidente aparatoso");
            }
            else if(A2.Vacia()==false){
                A2.Atender(aux);
                flag=1;
                Console.WriteLine("Se atendió a un adulto con infarto");
            }
            else if(A3.Vacia()==false){
                A3.Atender(aux);
                flag=1;
                Console.WriteLine("Se atendió a un adulto con afecciones respiratorias");
            }
            else if(A4.Vacia()==false){
                A4.Atender(aux);
                flag=1;
                Console.WriteLine("Se atendió a una mujer en labor de parto");
            }
            else if(A5.Vacia()==false){
                A5.Atender(aux);
                flag=1;
                Console.WriteLine("Se atendió a un adulto con enfermedad menor");
            }

            return flag;
        }

        public void Reporte(Cola N1,Cola N2, Cola N3, Cola N4, Cola N5,Cola A1, Cola A2, Cola A3, Cola A4, Cola A5,Paciente aux){
            int CN1=0,CN2=0,CN3=0,CN4=0,CN5=0,CA1=0,CA2=0,CA3=0,CA4=0,CA5=0,CT=0;
            
            if(N1.Vacia()==false){
                CN1=N1.VerFin+1;
            }
            if(N2.Vacia()==false){
                CN2=N2.VerFin+1;
            }
            if(N3.Vacia()==false){
                CN3=N3.VerFin+1;
            }
            if(N4.Vacia()==false){
                CN4=N4.VerFin+1;
            }
            if(N5.Vacia()==false){
                CN5=N5.VerFin+1;
            }

            if(A1.Vacia()==false){
                CA1=A1.VerFin+1;
            }
            if(A2.Vacia()==false){
                CA2=A2.VerFin+1;
            }
            if(A3.Vacia()==false){
                CA3=A3.VerFin+1;
            }
            if(A4.Vacia()==false){
                CA4=A4.VerFin+1;
            }
            if(A5.Vacia()==false){
                CA5=A5.VerFin+1;
            }

            CT= CN1+CN2+CN3+CN4+CN5+CA1+CA2+CA3+CA4+CA5;

            if(CT==0){
                Console.WriteLine("NO HAY EN ESPERA");
            }

            else{
                Console.WriteLine($"\n\t.:REPORTE:.\n- HAY: {CN1} NIÑOS EN ESPERA POR ACCIDENTE APARATOSO\n- HAY: {CN2} NIÑOS EN ESPERA POR INFARTO\n- HAY: {CN3} NIÑOS EN ESPERA POR AFECCIONES RESPIRATORIAS\n- HAY: {CN4} NIÑAS EN ESPERA POR PARTO\n- HAY: {CN5} NIÑOS EN ESPERA POR ENFERMEDADES MENORES");
                Console.WriteLine($"\n- HAY: {CA1} ADULTOS EN ESPERA POR ACCIDENTE APARATOSO\n- HAY: {CA2} ADULTOS EN ESPERA POR INFARTO\n- HAY: {CA3} ADULTOS EN ESPERA POR AFECCIONES RESPIRATORIAS\n- HAY: {CA4} MUJERES EN ESPERA POR PARTO\n- HAY: {CA5} ADULTOS EN ESPERA POR ENFERMEDADES MENORES");
                
                string mot;
                if(aux.VerMotivo==1){
                    mot="ACCIDENTE APARATOSO";
                }
                if(aux.VerMotivo==2){
                    mot="INFARTO";
                }
                if(aux.VerMotivo==3){
                    mot="AFECCION RESPIRATORIA";
                }
                if(aux.VerMotivo==4){
                    mot="PARTO";
                }
                else{
                    mot="ENFERMEDAD MENOR";
                }
                Console.WriteLine("- UN PACIENTE POR ",mot," SE ESTA ATENDIENDO EN ESTE MOMENTO");
            }
        }

    }
}

