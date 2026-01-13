using System;

class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job (); // porque colocar Job na frente de job1 - new ai tem que escrever Job de novo porque?
       job1._jobTitle = "Softwere engineer";
       job1._company = "(Microsoft)";
       job1._startYear = 2019; // porque se eu escrever "2019 da erro" com os aspas
       job1._endYear = 2022;


       Job job2 = new Job();
       job2._jobTitle = "manager";
       job2._company = "(Apple)";
       job2._startYear = 2022; 
       job2._endYear = 2023;

       //job1.Display(); // pirque preciso colocar () depois do display?
       //job2.Display();

        Resume myResume = new Resume(); // porque teve que usar essa função? ou criar essa nova lista, quando na atividade me pede para create a new instance of the Resume class eu devo fazer isso? criar algo como  Resume myResume = new Resume(); para que possa usar dados de varios arquivos diferentes?
        myResume._name = "Allison Rose"; // porque deu o nome?

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}