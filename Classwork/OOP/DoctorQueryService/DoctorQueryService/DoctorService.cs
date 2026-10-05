using ConsoleApp8.Model;

namespace ConsoleApp8
{
    internal class DoctorService
    {

        public Doctor[] GetAll()
        {
            Doctor doctor1 = new Doctor();
            doctor1.FullName = "Samir Almammadli";
            doctor1.Age = 19;
            doctor1.Email = "xyz@code.edu.az";
            doctor1.Address = "Sumgayit";

            Doctor doctor2 = new Doctor();
            doctor2.FullName = "Emil Mirzeyev";
            doctor2.Age = 21;
            doctor2.Email = "abc@code.edu.az";
            doctor2.Address = "Baku";

            Doctor doctor3 = new Doctor();
            doctor3.FullName = "Aysel Huseynova";
            doctor3.Age = 25;
            doctor3.Email = "aysel@code.edu.az";
            doctor3.Address = "Ganja";

            Doctor doctor4 = new Doctor();
            doctor4.FullName = "Murad Aliyev";
            doctor4.Age = 30;
            doctor4.Email = "murad@code.edu.az";
            doctor4.Address = "Shaki";

            Doctor doctor5 = new Doctor();
            doctor5.FullName = "Leyla Mammadova";
            doctor5.Age = 28;
            doctor5.Email = "leyla@code.edu.az";
            doctor5.Address = "Lankaran";

            return new Doctor[] { doctor1, doctor2, doctor3, doctor4, doctor5 };
        }



        public void SearchByFullName(Doctor[] doctorArray ,string searchingText)
        {           
            foreach (var doctor in doctorArray)
            {
                if (doctor.FullName.Contains(searchingText.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"FullName: {doctor.FullName}, Age: {doctor.Age}, Email: {doctor.Email}, Address: {doctor.Address}");
                }
               
            }
        }

        public Doctor[] SortByAge(Doctor[] doctorArray,string keyValue)
        {
            switch (keyValue) {
                case "asc":
                Array.Sort(doctorArray, (d1, d2) => d1.Age.CompareTo(d2.Age));
                    break;

                case "desc":
                Array.Sort(doctorArray, (d1, d2) => d2.Age.CompareTo(d1.Age));
                    break;
            }
            return doctorArray;
        }

        public int GetAvarageByAge(Doctor[] doctorArray)
        {
            int result = 0;
            foreach(var doctor in doctorArray)
            {
                result += doctor.Age;
            }
            return result / doctorArray.Length;
        }
    }
}
