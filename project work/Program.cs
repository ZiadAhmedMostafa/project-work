using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Policy;
namespace project_work
{
    internal class Program
    {
     //#methode 1
        static void var_distanca_choice()
        {
            Console.WriteLine("please choose what you want to do :-");
            Console.WriteLine("write '1' to enter distance ");
            Console.WriteLine("write '2' to return to home page ");
            Console.WriteLine("write '3' to close the APP. \n");
        }
     //#methode 2
        static void invalide_zero()
        {
            Console.Clear();
            Console.WriteLine("invalide zero");
        }
     //#main methode
        static void Main(string[] args)
        {
            Console.WriteLine("happy to help you");
    // variable
            string rectangular, triangle, circle, square;
            string var_switch;int var_distanca;
            char continuo;
            float perimeter, area;
            double circumference;
            //distance variable
            float pi, width, length, height, radius, side1, side2, bas, size;
            //array of history            
            List <string> historys = new List<string>();
    // first page 
        s:
            Console.WriteLine("choose from geometric shapes :-");
            G :
            Console.WriteLine("( square - triangle - rectangular - circle - rhombus - parallelogram - parallelepiped - cube ) ");
            Console.WriteLine("write 'exite' for close the APP.");
            Console.WriteLine("write 'history' to watch your operations history");
            
            Console.Write("enter your choosed shape :-"); var_switch = Console.ReadLine().ToLower();


    //second step 
            Console.Clear();/*clear last code*/
            switch (var_switch) {
    //#rectangular.
                case "rectangular":
                    Console.WriteLine("area = length * width ");
                    Console.WriteLine("perimeter = ( length +width ) * 2");
                    K :
                    var_distanca_choice();
                    var_distanca = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (var_distanca == 1)
                        {
                        do { 
                            Console.Clear() ;
                            k:
                            try
                            {
                                try
                                {
                                    Console.WriteLine("please enter width :-");
                                    width = float.Parse(Console.ReadLine());
                                    Console.WriteLine("please enter length");
                                    length = float.Parse(Console.ReadLine());
                                }
                                catch (DivideByZeroException)
                                {
                                    Console.Clear();
                                    Console.WriteLine("DivideByZeroException");
                                    goto K;
                                }
                            }
                            catch (FormatException) 
                            {
                                Console.Clear();
                                Console.WriteLine("FormatException");
                                goto K;
                            }
                            if (width != 0 && length != 0)
                            {
                                area = ((length * width));
                                Console.WriteLine($"area = {area} m^2 ");
                                perimeter = ((length + width) * 2);
                                Console.WriteLine($"perimeter = {perimeter} m ");
                            }
                            else
                            {
                                invalide_zero();
                                goto K;
                            }
                         Console.Write(" write'y' to do another operatiopn \n write 'h' to back to home page  \n write any another simbol to exite ");
                         continuo = char.Parse(Console.ReadLine());
     /* add history */   historys.Add($"choised shape = {var_switch} \nwidth = {width} \nlength = {length} \narea = {area} m^2\n perimeter = {perimeter} m ");
                        }
                        while (continuo == 'y') ;
                        if (continuo == 'h')
                        {
                            Console.Clear();
                            goto s;
                        }
                        else if (continuo != 'h' )
                        {
                         Console.Clear();
                         goto z;
                         }                    
                        }
                    else if (var_distanca == 2)
                    { goto s; }
                    else if (var_distanca == 3)
                    { goto z; }

                    else
                    {
                        Console.WriteLine("please enter correct number.");
                        goto K;
                    }
                break;
    //#square.
                case "square":
                    Console.WriteLine("area = length * width ");
                    Console.WriteLine("perimeter = length * 4");
                R:
                    var_distanca_choice();
                    var_distanca = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (var_distanca == 1)
                    {
                        do
                        {                             
                            Console.Clear ();
                            a:
                            try { 
                                try { 

                                  Console.WriteLine("please enter length");
                                  length = float.Parse(Console.ReadLine());
                        }
                                catch (DivideByZeroException)
                                {
                                  Console.Clear();
                                  Console.WriteLine("DivideByZeroException");
                                  goto a;
                                }
                    }
                            catch (FormatException)
                            {
                        Console.Clear();
                        Console.WriteLine("FormatException");
                        goto a;
                    }
                            if (length != 0)
                            {
                                area = ((length * length));
                                Console.WriteLine($"area = {area} m^2 ");
                                perimeter = ((length * 4));
                                Console.WriteLine($"perimeter {perimeter} m ");
                            }
                            else
                            {
                                invalide_zero();
                                goto a;
                            }
                        Console.Write(" write'y' to do another operatiopn \n write 'h' to back to home page  \n write any another simbol to exite ");
                        continuo = char.Parse(Console.ReadLine());
  /* add history */     historys.Add($"choised shape = {var_switch} \nlength = {length} \narea = {area} m^2 \nperimeter = {perimeter} m ");

                        }
                         while (continuo == 'y') ;
                        if (continuo == 'h')
                        {
                            Console.Clear();
                            goto s;
                        }
                        else if (continuo != 'h')
                        {
                            Console.Clear();
                            goto z;
                        }
                    }
                    else if (var_distanca == 2)
                    { goto s; }
                    else if (var_distanca == 3)
                    { goto z; }

                    else
                    {
                        Console.WriteLine("please enter correct number.");
                        goto R;
                    }
                    break;
    //#CIRCLE.
                case "circle":
                    Console.WriteLine("area = r^2 * pi ");
                    Console.WriteLine("circumference = pi * r * 2");
                U:
                    var_distanca_choice();
                    var_distanca = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (var_distanca == 1)
                    {
                        do {
                            Console.Clear();
                            x:
                            try { 
                                try { 
                        //pi = 3.14;
                        Console.WriteLine("please enter radius :-");
                        radius = float.Parse(Console.ReadLine());
                                }
                                catch (DivideByZeroException)
                                {
                                    Console.Clear();
                                    Console.WriteLine("DivideByZeroException");
                                    goto x;
                                }
                            }
                            catch (FormatException)
                            {
                                Console.Clear();
                                Console.WriteLine("FormatException");
                                goto x;
                            }
                            if (radius != 0)
                            {
                                area = ((radius * radius) * 2);
                                Console.WriteLine($"area = {area} m^2 ");
                                circumference = ((3.14 * radius * 2));
                                Console.WriteLine($"circumference {circumference} m ");
                            }
                            else
                            {
                                invalide_zero();
                                goto x;
                            }
                        Console.Write(" write'y' to do another operatiopn \n write 'h' to back to home page  \n write any another simbol to exite ");
                        continuo = char.Parse(Console.ReadLine());
   /* add history */    historys.Add($"choised shape = {var_switch} \nradius = {radius} \narea = {area} m^2 \ncircumference = {circumference} m ");
                        }
                        while (continuo == 'y') ;
                        if (continuo == 'h')
                        {
                            Console.Clear();
                            goto s;
                        }
                        else if (continuo != 'h')
                        {
                            Console.Clear();
                            goto z;
                        }
                    }
                    else if (var_distanca == 2)
                    { goto s; }
                    else if (var_distanca == 3)
                    { goto z; }

                    else
                    {
                        Console.WriteLine("please enter correct number.");
                        goto U;
                    }
                    break;
    //#triangle.
                case "triangle":
                    Console.WriteLine("area = base * height * 0.5 ");
                    Console.WriteLine("perimeter = sum of three sides 's1+s2+s3'");
                O:
                    var_distanca_choice();
                    var_distanca = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (var_distanca == 1)
                    {
                        do {
                            Console.Clear() ;
                            i:
                            try { 
                                try { 
                            Console.WriteLine("please enter length of base :-");
                            bas = float.Parse(Console.ReadLine());
                            Console.WriteLine("please enter height :-");
                            height = float.Parse(Console.ReadLine());
                            Console.WriteLine("please enter length of side1 :- ");
                            side1 = float.Parse(Console.ReadLine());
                            Console.WriteLine("please enter length of side2 :- ");
                            side2 = float.Parse(Console.ReadLine());
                                }
                                catch (DivideByZeroException)
                                {
                                    Console.Clear();
                                    Console.WriteLine("DivideByZeroException");
                                    goto i;
                                }
                            }
                            catch (FormatException)
                            {
                                Console.Clear();
                                Console.WriteLine("FormatException");
                                goto i;
                            }
                            if (bas != 0 && side1 != 0 && side2 != 0 && height != 0)
                            {
                                area = (((height * bas) / 2));
                                Console.WriteLine($"area = {area} m^2 ");
                                perimeter = ((side1 + side2 + bas));
                                Console.WriteLine($"perimeter {perimeter} m ");
                            }
                            else
                            {
                                invalide_zero();
                                goto i;
                            }
                            Console.Write(" write'y' to do another operatiopn \n write 'h' to back to home page  \n write any another simbol to exite ");
                            continuo = char.Parse(Console.ReadLine());
                            /* add history */
                            historys.Add($"choised shape = {var_switch} \nbase = {bas} \nheight = {height} \nside1 = {side1} \nside2 = {side2} \narea = {area} m^2 \nperimeter = {perimeter} m ");
                        }
                        while (continuo == 'y');
                        if (continuo == 'h')
                        {
                            Console.Clear();
                            goto s;
                        }
                        else if (continuo != 'h')
                        {
                            Console.Clear();
                            goto z;
                        }
                    }
                    else if (var_distanca == 2)
                    { goto s; }
                    else if (var_distanca == 3)
                    { goto z; }

                    else
                    {
                        Console.WriteLine("please enter correct number.");
                        goto O;
                    }
                    break;
    //#rhombus. 
                case "rhombus":
                    Console.WriteLine("area = length * height ");
                    Console.WriteLine("perimeter = length * 4 ");
                Q:
                    var_distanca_choice();
                    var_distanca = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (var_distanca == 1)
                    {
                        do
                        {
                            Console.Clear ();
                            h:
                            try
                            {
                                try { 
                            Console.WriteLine("please enter height :-");
                            height = float.Parse(Console.ReadLine());
                            Console.WriteLine("please enter length");
                            length = float.Parse(Console.ReadLine());
                                }
                                catch (DivideByZeroException)
                                {
                                    Console.Clear();
                                    Console.WriteLine("DivideByZeroException");
                                    goto h;
                                }
                            }
                            catch (FormatException)
                            {
                                Console.Clear();
                                Console.WriteLine("FormatException");
                                goto h;
                            }
                            if (height != 0 && length != 0)
                            {
                                area = ((length * height));
                                Console.WriteLine($"area = {area} m^2 ");
                                perimeter = ((length * 4));
                                Console.WriteLine($"perimeter = {perimeter} m ");
                            }
                            else
                            {
                                invalide_zero();
                                goto h;
                            }
                            Console.Write(" write'y' to do another operatiopn \n write 'h' to back to home page  \n write any another simbol to exite ");
                            continuo = char.Parse(Console.ReadLine());
    /* add history */       historys.Add($"choised shape = {var_switch} \nheight = {height} \nlength = {length} \narea = {area} m^2 \nperimeter = {perimeter} m ");
                        }
                        while (continuo == 'y');
                        if (continuo == 'h')
                        {
                            Console.Clear();
                            goto s;
                        }
                        else if (continuo != 'h')
                        {
                            Console.Clear();
                            goto z;
                        }
                    }
                    else if (var_distanca == 2)
                    { goto s; }
                    else if (var_distanca == 3)
                    { goto z; }

                    else
                    {
                        Console.WriteLine("please enter correct number.");
                        goto Q;
                    }
                    break;
    //#parallelogram.
                case "parallelogram":
                    Console.WriteLine("area = base * height ");
                    Console.WriteLine("perimeter = (base + width)*2");
                W:
                    var_distanca_choice();
                    var_distanca = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (var_distanca == 1)
                    {
                        do
                        {
                            Console.Clear ();
                            m:
                            try { 
                                try { 
                            Console.Write("please enter height :- ");
                            height = float.Parse(Console.ReadLine());
                            Console.Write("please enter width:- ");
                            width= float.Parse(Console.ReadLine());
                            Console.Write("please enter length :- ");
                            bas = float.Parse(Console.ReadLine());
                                }
                                catch (DivideByZeroException)
                                {
                                    Console.Clear();
                                    Console.WriteLine("DivideByZeroException");
                                    goto m;
                                }
                            }
                            catch (FormatException)
                            {
                                Console.Clear();
                                Console.WriteLine("FormatException");
                                goto m;
                            }
                            if (bas != 0 && width != 0 && height != 0)
                            {
                                area = ((bas * height));
                                Console.WriteLine($"area = {area} m^2 ");
                                perimeter = ((bas + width) * 2);
                                Console.WriteLine($"perimeter = {perimeter} m ");
                            }
                            else
                            {
                                invalide_zero();
                                goto m;
                            }
                            Console.Write(" write'y' to do another operatiopn \n write 'h' to back to home page  \n write any another simbol to exite ");
                            continuo = char.Parse(Console.ReadLine());
    /* add history */       historys.Add($"choised shape = {var_switch} \nheight = {height} \nwidth = {width} \nbase = {bas} \narea = {area} m^2 \nperimeter = {perimeter} m ");

                        }
                        while (continuo == 'y');
                        if (continuo == 'h')
                        {
                            Console.Clear();
                            goto s;
                        }
                        else if (continuo != 'h')
                        {
                            Console.Clear();
                            goto z;
                        }
                    }
                    else if (var_distanca == 2)
                    { goto s; }
                    else if (var_distanca == 3)
                    { goto z; }

                    else
                    {
                        Console.WriteLine("please enter correct number.");
                        goto W;
                    }
                    break;
    //#parallelepiped.
                case "parallelepiped":
                    Console.WriteLine("area = 2(height * length) + 2(height * width) + 2(width * length)");
                    Console.WriteLine("size = (length * height * width)");
                J:
                    var_distanca_choice();
                    var_distanca = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (var_distanca == 1)
                    {
                        do
                        {
                             
                            Console.Clear ();
                            f:
                            try
                            {
                                try { 
                            
                            Console.Write("please enter height :- ");
                            height = float.Parse(Console.ReadLine());
                            Console.Write("please enter width:- ");
                            width = float.Parse(Console.ReadLine());
                            Console.Write("please enter length :- ");
                            length = float.Parse(Console.ReadLine());
                                }
                                catch (DivideByZeroException)
                                {
                                    Console.Clear();
                                    Console.WriteLine("DivideByZeroException");
                                    goto f;
                                }
                            }
                            catch (FormatException)
                            {
                                Console.Clear();
                                Console.WriteLine("FormatException");
                                goto f;
                            }
                            if (length != 0 && height != 0 && width != 0)
                            {
                                area = (2 * (height * length) + 2 * (height * width) + 2 * (width * length));
                                Console.WriteLine($"area = {area} m^2 ");
                                size = (length * height * width);
                                Console.WriteLine($"size = {size} m^3 ");
                            }
                            else
                            {
                                invalide_zero();
                                goto f;
                            }
                            Console.Write(" write'y' to do another operatiopn \n write 'h' to back to home page  \n write any another simbol to exite ");
                            continuo = char.Parse(Console.ReadLine());
                            /* add history */
                            historys.Add($"choised shape = {var_switch} \nheight = {height} \nwidth = {width} \nlength = {length} \narea = {area} m^2 \nsize = {size} m^3 ");

                        }
                        while (continuo == 'y');
                        if (continuo == 'h')
                        {
                            Console.Clear();
                            goto s;
                        }
                        else if (continuo != 'h')
                        {
                            Console.Clear();
                            goto z;
                        }
                    }
                    else if (var_distanca == 2)
                    { goto s; }
                    else if (var_distanca == 3)
                    { goto z; }

                    else
                    {
                        Console.WriteLine("please enter correct number.");
                        goto J;
                    }
                    break;
    //cube...
                case "cube":
                    
                    Console.WriteLine("area = (length * length) *6");
                    Console.WriteLine("size = (length * length * length)");
                Y:
                    var_distanca_choice();
                    var_distanca = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (var_distanca == 1)
                    {
                        do
                        {
                            Console.Clear();
                        q:
                            try {
                                try {
                                    Console.Write("please enter length :- ");
                                    length = float.Parse(Console.ReadLine());
                                }
                                catch (DivideByZeroException)
                                {
                                    Console.Clear();
                                    Console.WriteLine("DivideByZeroException");
                                    goto q;
                                }
                            }
                            catch (FormatException)
                            {
                                Console.Clear();
                                Console.WriteLine("FormatException");
                                goto q;
                            }
                            if (length != 0) {
                                area = ((length * length) * 6);
                                Console.WriteLine($"area = {area} m^2 ");
                                size = (length * length * length);
                                Console.WriteLine($"size = {size} m^3 ");
                            }
                            else 
                            {
                                invalide_zero();
                                goto q;
                            }
                            Console.Write(" write'y' to do another operatiopn \n write 'h' to back to home page  \n write any another simbol to exite ");
                                continuo = char.Parse(Console.ReadLine());
                                /* add history */
                                historys.Add($"choised shape = {var_switch} \nlength = {length} \narea = {area} m^2 \nsize = {size} m^3 ");

                            }
                            while (continuo == 'y') ;
                            if (continuo == 'h')
                            {
                                Console.Clear();
                                goto s;
                            }
                            else if (continuo != 'h')
                            {
                                Console.Clear();
                                goto z;
                            }
                        }
                    else if (var_distanca == 2)
                        { goto s; }
                        else if (var_distanca == 3)
                        { goto z; }

                        else {
                            Console.WriteLine("please enter correct number.");
                            goto Y;
                        }
                        break; 
    //exite..
                case "exite":
                    goto z;
                    break;
    //histoey
                case "history":
                    foreach (string memory in historys)
                    {
                        Console.WriteLine($"{memory}  \n--------------------------\n");
                    }
                    Console.WriteLine("write '1' to return to home page ");
                    Console.WriteLine("write '2' to close the APP.");
                    var_distanca = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (var_distanca == 1) { goto s; }
                    if (var_distanca == 2)
                    { goto z; }
                    break; 
    //default
                default:
             Console.WriteLine("please enter correct shape.");
                    goto G;
                break;
             }
        z:
            Console.WriteLine("proud to help you");
        }
    }
}
