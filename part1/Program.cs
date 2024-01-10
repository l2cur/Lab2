namespace lab2
{
    public class Program
    {
        static void Main()
        {
            ExcelentPupil pupil1 = new ExcelentPupil();
            GoodPupil pupil2 = new GoodPupil();
            BadPupil pupil3 = new BadPupil();
            ExcelentPupil pupil4 = new ExcelentPupil();

            ClassRoom classRoom1 = new ClassRoom(pupil1, pupil2);
            ClassRoom classRoom2 = new ClassRoom(pupil1, pupil2, pupil3);
            ClassRoom classRoom3 = new ClassRoom(pupil1, pupil2, pupil3, pupil4);

            Console.WriteLine($"class 1");
            classRoom1.PupilsDoIt();

            Console.WriteLine($"\nclass 2");
            classRoom2.PupilsDoIt();

            Console.WriteLine($"\nclass 3");
            classRoom3.PupilsDoIt();
        }
    }

    public class ExcelentPupil : Pupil 
    { 
        public override void Study() { Console.WriteLine($"excelent pupil study"); }
        public override void Read() { Console.WriteLine($"excelent pupil read"); }
        public override void Write() { Console.WriteLine($"excelent pupil write"); }
        public override void Relax() { Console.WriteLine($"excelent pupil relax"); }
    }
    public class GoodPupil : Pupil
    {
        public override void Study() { Console.WriteLine($"good pupil study"); }
        public override void Read() { Console.WriteLine($"good pupil read"); }
        public override void Write() { Console.WriteLine($"good pupil write"); }
        public override void Relax() { Console.WriteLine($"good pupil relax"); }
    }
    public class BadPupil : Pupil
    {
        public override void Study() { Console.WriteLine($"bad pupil study"); }
        public override void Read() { Console.WriteLine($"bad pupil read"); }
        public override void Write() { Console.WriteLine($"bad pupil write"); }
        public override void Relax() { Console.WriteLine($"bad pupil relax"); }
    }
    public class ClassRoom
    {
        Pupil[] pupils = new Pupil[4];
        public ClassRoom(params Pupil[] pupil)
        {
            for (int i = 0; i < pupils.Length; i++)
            {
                this.pupils[i] = new Pupil();
            }
            for (int i = 0; i < pupil.Length; i++)
            {
                this.pupils[i] = pupil[i];
            }
        }
        public void PupilsDoIt()
        {
            for (int i = 0; i < 4; i++)
            {
                pupils[i].Study();
                pupils[i].Read();
                pupils[i].Write();
                pupils[i].Relax();
            }
        }
    }

    public class Pupil
    {
        public virtual void Study() { Console.WriteLine($"pupil study"); }
        public virtual void Read() { Console.WriteLine($"pupil read"); }
        public virtual void Write() { Console.WriteLine($"pupil write"); }
        public virtual void Relax() { Console.WriteLine($"pupil relax"); }
    }
}