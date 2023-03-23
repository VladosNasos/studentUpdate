using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Group group1 = new Group();
        group1.ShowStudents();
        Console.WriteLine();

        Group group2 = new Group(group1);
        group2.EditGroup("Pivololovers", "Pivopitie", 2);
        group2.EditStudent(1, "Antonio", "Pivovenko", 20, 10);
        group2.EditStudent(2, "Pivo", "Pivov", 20, 10);
        group2.ShowStudents();

        if (group1.checkEqualStudents(1, 2)) Console.WriteLine("\nStuds Equal\n");
        else Console.WriteLine("\nStuds Not Equal\n");
        if (group1 == group2) Console.WriteLine("\nGroups Equal\n");
        else Console.WriteLine("\nGroups Not Equal\n");

        Console.WriteLine();

        group2.TransferStudent(0, group1);
        group1.ShowStudents();
        group2.ShowStudents();
        Console.WriteLine();

        group2.ExpelFailedStudents();
        group2.ShowStudents();
        Console.WriteLine();

        group2.ExpelWorstStudent();
        group2.ShowStudents();
        Console.WriteLine();
    }
}
