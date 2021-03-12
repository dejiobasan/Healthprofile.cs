using System;

namespace Healthprofile
{
    public class HealthProfile
    {

        public string firstName;
        public string lastName;
        public string MoB;
        public int DoB;
        public int YoB;
        public int currentYear;
        public int height;
        public int weight;
        public string gender;



        public void SetFirstName(string FirstName)
        {
            firstName = FirstName;
        }

        public void SetLastName(string LastName)
        {
            lastName = LastName;
        }

        public void SetDoB(int DayofBirth)
        {
            DoB = DayofBirth;
        }

        public void SetMoB(string MonthofBirth)
        {
            MoB = MonthofBirth;
        }

        public void SetYoB(int YearofBirth)
        {
            YoB = YearofBirth;
        }

        public void SetYear(int CurrentYear)
        {
            currentYear = CurrentYear;
        }

        public void SetHeight(int Height)
        {
            height = Height;
        }

        public void SetWeight(int Weight)
        {
            weight = Weight;
        }

        public void SetGender(string Gender)
        {
            gender = Gender;
        }

        // following methods retrieves the information from the object
        public string GetFirstName()
        {
            return firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public int GetDoB()
        {
            return DoB;
        }

        public string GetMoB()
        {
            return MoB;
        }

        public int GetYoB()
        {
            return YoB;
        }

        public int GetYear()
        {
            return currentYear;
        }

        public int GetHeight()
        {
            return height;
        }

        public int GetWeight()
        {
            return weight;
        }

        public string GetGender()
        {
            return gender;
        }
    }

    public class Healthprofiletest
    {
        public static void Main(string[] args)
        {


            HealthProfile healthprofile = new HealthProfile();
            Console.WriteLine("Hello, please enter your information so we can calculate your max and target heart rates!");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();


            Console.WriteLine("Enter First Name: ");
            string firstName = Console.ReadLine();
            healthprofile.SetFirstName(firstName);

            Console.WriteLine("Enter Last Name: ");
            string lastName = Console.ReadLine();
            healthprofile.SetLastName(lastName);

            Console.WriteLine("Enter The day You Were Born: ");
            int dob = Convert.ToInt32(Console.ReadLine());
            healthprofile.SetDoB(dob);

            Console.WriteLine("Enter The month You Were Born: ");
            string mob = Console.ReadLine();
            healthprofile.SetMoB(mob);

            Console.WriteLine("Enter The year You Were Born: ");
            int yob = Convert.ToInt32(Console.ReadLine());
            healthprofile.SetDoB(yob);

            Console.WriteLine("Enter Your Height In Inches: ");
            int height = Convert.ToInt32(Console.ReadLine());
            healthprofile.SetHeight(height);

            Console.WriteLine("Enter Your Weight In Pounds: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            healthprofile.SetWeight(weight);

            Console.WriteLine("Enter Your Gender: ");
            string gender = Console.ReadLine();
            healthprofile.SetGender(gender);

            Console.WriteLine("Enter The Current Year: ");
            int currentYear = Convert.ToInt32(Console.ReadLine());
            healthprofile.SetYear(currentYear);


            // Calculate HeartRate / BPM
            int beatsperMin = 220;
            int Age = (currentYear - yob);
            int MaxHeartRate = beatsperMin - Age;
            double HeartMultiplier50 = 0.5;
            double HeartMultiplier85 = 0.85;
            double TargetHeartRateLow = Convert.ToDouble(HeartMultiplier50 * MaxHeartRate);
            double TargetHeartRateHigh = Convert.ToDouble(HeartMultiplier85 * MaxHeartRate);

            // Calculate BMI
            int BMI = (weight * 703) / (height * height);
            // Statement to calculate BMI Value
            string BMIValue;
            if (BMI <= 18.5)
            {
                BMIValue = "underweight";
            }
            else if (BMI > 18.5 && BMI < 24.9)
            {
                BMIValue = "normal";
            }
            else if (BMI > 25 && BMI < 29.9)
            {
                BMIValue = "overweight";
            }
            else
            {
                BMIValue = "obese";
            }

            Console.WriteLine(
                "\nYou Entered\n"
                + "Name: " + firstName + " " + lastName + "\n"
                + "Birth Year: " + yob + "\n"
                + "Current Year: " + currentYear + "\n"
                + "You Are Currently: " + Age + " Years Old" + "\n"
                + "Your MAX Heart Rate Is: " + MaxHeartRate + "\n"
                + "Your Target Heart Rate Is Between: " + TargetHeartRateLow + " and " + TargetHeartRateHigh + "\n"
                + "Your BMI Is: " + BMI + "\n"
                + "Due to your BMI of: " + BMI + " ,you are considered to be " + BMIValue + "\n"
             );

            Console.ReadLine();
        }
    }
}
