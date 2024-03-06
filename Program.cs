using System.Collections;
using Microsoft.VisualBasic;
using TallerEstructura;
using TallerEstructura2;
using TallerEstructura3;
using TallerEstructura4;

namespace Asignacion2;

class Program
{
    static void Main(string[] args)
    {   

        Cola N1 = new Cola(100);
        Cola N2 = new Cola(100);
        Cola N3 = new Cola(100);
        Cola N4 = new Cola(100);
        Cola N5 = new Cola(100);
        Cola A1 = new Cola(100);
        Cola A2 = new Cola(100);
        Cola A3 = new Cola(100);
        Cola A4 = new Cola(100);
        Cola A5 = new Cola(100);
        Paciente aux = new Paciente();
        Consultorio Hospital = new Consultorio();

        Hospital.menu(N1,N2,N3,N4,N5,A1,A2,A3,A4,A5,aux);        

    }

    

}
