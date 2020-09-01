using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private readonly List<SGrade> SchoolStudents = new List<SGrade>();
    private class SGrade//get/set pra setar e buscar o valor de uma variável interna
    {
        public string Name { get; set; }
        public int _Grade { get; set; }
    }
    public void Add(string student, int grade)//metodo para adicionar estudantes na lista
    {
        SchoolStudents.Add(new SGrade
        {
            Name = student,
            _Grade = grade
        });//adicionando nome e turma
    }

    public IEnumerable<string> Roster()
    {
        var allSchoolStudents = new List<string>();
        if (SchoolStudents.Any())//se tiver algum elemento, vai entrar no if
        {
            for (int x = 1; x <= SchoolStudents.Max(q => q._Grade); x++)//vai retornar uma lista com as turmas, vai pegar o max e adicionando nas turmas
            {
                allSchoolStudents.AddRange(Grade(x));//
            }
        }
        return allSchoolStudents;
    }

    public IEnumerable<string> Grade(int grade)
    {
        var gradeStudents = new List<string>();
        foreach(var student in SchoolStudents)
        {
            if(student._Grade == grade)
            {
                gradeStudents.Add(student.Name);
            }
        }
        return gradeStudents.OrderBy(q => q);//retornar em ordem alfabética
    }
}