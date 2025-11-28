namespace RijSchool;

class Program
{
    internal LesUur[] lesuren = new LesUur[2];
    static void Main(string[] args)
    {
        Auto auto1 = new Auto()
        {
                automaat = true,
                kenteken = "AA824H",
                kilometerStand = 20567,
                merk = "Volkswagen"
        };

        Auto auto2 = new Auto()
        {
            automaat = false,
            kenteken = "KU786G",
            kilometerStand = 65739,
            merk = "Volvo"  
        };

        RijLeeraar rijLeeraar = new RijLeeraar()
        {
            leeftijd = 30,
            naam = "John",
            zzp = false  
        };

        LesUur lesUur1 = new LesUur()
        {
            auto = auto1,
            rijLeeraar = rijLeeraar,
            tijd = 1130,
            LesPakket = lespakket,
            RijTest = rijTest,
            TheorieTest = theorieTest
        };

        Student student1 = new Student()
        {
            naam = "Johan",
            leeftijd = 28,
            LesPakket = lespakket1,
            RijLeeraar = rijLeeraar,
            RijTest = rijTest1,
            TheorieTest = theorieTest1
        };

        LesPakket lespakket1 = new LesPakket()
        {
            urenGekocht = 20,
            urenVerbruikt = 8,
            examenPogingen = 4,
            automaat = false
        };

        RijTest rijTest1 = new RijTest()
        {
            gehaald = false,
            afnameDatum = Januari, 6
        };

        TheorieTest theorieTest1 = new TheorieTest()
        {
            aantalFouten = 3,
            gehaald = true,
            afnameDatum = Februari, 2
        };

        Student student2 = new Student()
        {
            naam = "Vanessa",
            leeftijd = 31,
            LesPakket = lespakket2,
            RijLeeraar = rijLeeraar,
            RijTest = rijTest2,
            TheorieTest = theorieTest2
        };

        LesPakket lespakket2 = new LesPakket()
        {
            urenGekocht = 20,
            urenVerbruikt = 8,
            examenPogingen = 4,
            automaat = false
        };

        RijTest rijTest2 = new RijTest()
        {
            gehaald = true,
            afnameDatum = Januari, 27
        };

        TheorieTest theorieTest2 = new TheorieTest()
        {
            aantalFouten = 12,
            gehaald = false,
            afnameDatum = Februari, 14
        };

        LesUur lesUur2 = new LesUur()
        {
            auto = auto2,
            rijLeeraar = rijLeeraar,
            tijd = 1400,
            LesPakket = lespakket2,
            RijTest = rijTest2,
            TheorieTest = theorieTest2
        };

        lesuren[0] = lesUur1;
        lesuren[1] = lesUur2;
    }
}
