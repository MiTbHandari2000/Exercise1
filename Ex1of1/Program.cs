using System;
using System.Collections;

namespace Ex2of2
{
    public class superclass
    {
        List<string> cities = new List<string>
        {
            "Mumbai",
            "Delhi",
            "Ahmedabad",
            "Surat",
            "Valsad",
            "Varanasi",
            "Chennai",
            "Bhopal",
            "Darjeeling",
        };

       
        public static void Main(string[] args)
        {
           new superclass().runnall();

        }

        private void runnall()
        {

            
            InDescending(cities);
            InAscending(cities);
            Orderbylength(cities);
            Ascendingbylength(cities);
            NamewithVD(cities);
            Getcount(cities);
            BOTH(cities);
            //FruitsWithColor(clas.fruits);
        }

        private void BOTH(List<string> COMBINE)
        {
            var resultset = from NAME in COMBINE
                            group NAME by NAME[0] into show 
                            select show;
            Console.WriteLine("CITY NAME WITH FIRST LETTER");
            foreach (var Group in resultset)
            {
                Console.WriteLine(("CityName = " + Group.Key));
                foreach (var cx in Group)
                {
                    Console.WriteLine(cx);
                }
            }
        }



        private void Getcount(List<string> cityname)
        {

            var resultset = from city in cityname
                            where city[0] == 'A'
                            select city;
            Console.WriteLine("Count with a");
            
            Console.WriteLine(resultset.Count());

            Console.WriteLine("");
        }

        private void NamewithVD(List<string> cityname)
        {
            
            var resultset = from city in cityname
                            where city[0]=='V'|| city[0] == 'D'
                            select city;
            Console.WriteLine("Most Expensive fruits");
            foreach (var name in resultset)
            {
                Console.WriteLine(name);

            }
            Console.WriteLine("");
        }

        private void Ascendingbylength(List<string> city)
        {
            var lengthofcityindescendingt = from cityname in city
                                            
                                            orderby cityname.Length
                                            select cityname;
            foreach (var fnl in lengthofcityindescendingt)
            {
                Console.WriteLine(fnl);
            }
            Console.WriteLine("");


        }

        private void Orderbylength(List<string> city)
        {
            var lengthofcityindescendingt = from cityname in city
                                            
                                            orderby cityname.Length descending
                                            select cityname;
            foreach (var fnl in lengthofcityindescendingt)
            {
                Console.WriteLine(fnl);
            }
            Console.WriteLine("");


        }
        private void InAscending(List<string> city)
        {
            var ascending = from cityname in city
                         orderby cityname ascending
                         select cityname;
            foreach (var ascend in ascending)
            {
                Console.WriteLine(ascend);
            }
            Console.WriteLine("");
        }

        private void InDescending(List<string> city)
        {
            var descending = from cityname in city
                            orderby cityname descending
                            select cityname;

            foreach (var fnl in descending)
            {
                Console.WriteLine(fnl);
            }
            Console.WriteLine("");
        }

    }
}