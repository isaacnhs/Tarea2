// See https://aka.ms/new-console-template for more information
using System;


int cedula = 0;
string NombreEmpleado = "";
string TipoEmpleado = "";
int SalarioHora = 0;
int CantidadHoras = 0;
float AumentoSalarial = 0;
float SalarioOrdinario = 0;
float SalarioBruto = 0;
float PorcDeduccionCCSS = 0.0917f;
float DeduccionCCSS = 0;
float SalarioNeto = 0;
int opcion = 0;

float TipoEmp = 0;
float Operario = 0.15f;
float Técnico = 0.10f;
float Profesional = 0.05f;

int cantidadOperarios = 0;
float acumuladoSalarioNetoOperarios = 0;
int cantidadTecnicos = 0;
float acumuladoSalarioNetoTecnicos = 0;
int cantidadProfesionales = 0;
float acumuladoSalarioNetoProfesionales = 0;

bool seguirRegistrando = true;

while (seguirRegistrando)
{
    /*Console.Clear();*/
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("***Cálculo de planillas***");
    Console.WriteLine("");
    Console.WriteLine("1- Operario");
    Console.WriteLine("2- Técnico");
    Console.WriteLine("3- Profesional");
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("¿Qué tipo de empleado desea seleccionar?: ");
    Console.WriteLine("");
    opcion = int.Parse(Console.ReadLine());


    Console.WriteLine("");
    Console.WriteLine("Digite el número de cédula del empleado: ");
    Console.WriteLine("");
    cedula = int.Parse(Console.ReadLine());

    Console.WriteLine("");
    Console.WriteLine("Digite el nombre del empleado: ");
    Console.WriteLine("");
    NombreEmpleado = Console.ReadLine();
    Console.WriteLine("");

    Console.WriteLine("Digite la cantidad de horas laboradas del empleado: ");
    Console.WriteLine("");
    CantidadHoras = int.Parse(Console.ReadLine());
    Console.WriteLine("");

    Console.WriteLine("Digite el salario por hora del empleado: ");
    Console.WriteLine("");
    SalarioHora = int.Parse(Console.ReadLine());
    Console.WriteLine("");

    SalarioOrdinario = CantidadHoras * SalarioHora;
    AumentoSalarial = SalarioOrdinario * TipoEmp;
    SalarioBruto = SalarioOrdinario + AumentoSalarial;
    DeduccionCCSS = SalarioBruto * PorcDeduccionCCSS;
    SalarioNeto = SalarioBruto - DeduccionCCSS;


    if (opcion == 1)
    {
        TipoEmp = Operario;
        TipoEmpleado = "Operario";
        cantidadOperarios++;

        acumuladoSalarioNetoOperarios += SalarioNeto;
    }
    else if (opcion == 2)
    {
        TipoEmp = Técnico;
        TipoEmpleado = "Técnico";
        cantidadTecnicos++;

        acumuladoSalarioNetoTecnicos += SalarioNeto;
    }
    else if (opcion == 3)
    {
        TipoEmp = Profesional;
        TipoEmpleado = "Profesional";
        cantidadProfesionales++;

        acumuladoSalarioNetoProfesionales += SalarioNeto;
    }

    Console.WriteLine("El número de cédula del empleado es: .........{0}", cedula);
    Console.WriteLine("El nombre del empleado es: ...................{0}", NombreEmpleado);
    Console.WriteLine("El tipo de empleado es: ......................{0}", TipoEmpleado);
    Console.WriteLine("La cantidad de horas trabajadas son: .........{0}", CantidadHoras);
    Console.WriteLine("El salario por hora trabajada es: ............" + SalarioHora + " colones");
    Console.WriteLine("El salario ordinario es: ....................." + SalarioOrdinario + " colones");
    Console.WriteLine("El aumento salarial es de: ..................." + AumentoSalarial + " colones");
    Console.WriteLine("El salario bruto es: ........................." + SalarioBruto + " colones");
    Console.WriteLine("El porcentaje de deducción de la CCSS es del: " + PorcDeduccionCCSS * 100 + " %");
    Console.WriteLine("La deducción de la CCSS es de: ..............." + DeduccionCCSS + " colones");
    Console.WriteLine("El salario neto es de: ......................." + SalarioNeto + " colones");

    Console.WriteLine("");
    Console.WriteLine("¿Desea registrar otro empleado? (Si / No): ");
    Console.WriteLine("");
    string respuesta = Console.ReadLine();
    seguirRegistrando = (respuesta.ToLower() == "si" || respuesta.ToLower() == "s");
}

Console.WriteLine("");
Console.WriteLine("Estadísticas:");
Console.WriteLine("");
Console.WriteLine("1) Cantidad Empleados Tipo Operarios: ............" + cantidadOperarios);
Console.WriteLine("2) Acumulado Salario Neto para Operarios: ........" + acumuladoSalarioNetoOperarios);
Console.WriteLine("3) Promedio Salario Neto para Operarios: ........." + (cantidadOperarios > 0 ? acumuladoSalarioNetoOperarios / cantidadOperarios : 0));
Console.WriteLine("");
Console.WriteLine("4) Cantidad Empleados Tipo Técnicos: ............." + cantidadTecnicos);
Console.WriteLine("5) Acumulado Salario Neto para Técnicos: ........." + acumuladoSalarioNetoTecnicos);
Console.WriteLine("6) Promedio Salario Neto para Técnicos: .........." + (cantidadTecnicos > 0 ? acumuladoSalarioNetoTecnicos / cantidadTecnicos : 0));
Console.WriteLine("");
Console.WriteLine("7) Cantidad Empleados Tipo Profesional: .........." + cantidadProfesionales);
Console.WriteLine("8) Acumulado Salario Neto para Profesionales: ...." + acumuladoSalarioNetoProfesionales);
Console.WriteLine("9) Promedio Salario Neto para Profesionales: ....." + (cantidadProfesionales > 0 ? acumuladoSalarioNetoProfesionales / cantidadProfesionales : 0));