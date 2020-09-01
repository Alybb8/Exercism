using System;
using System.Linq;
using System.Collections.Generic;

public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{

    private readonly int auxMask; // uma var que pode ser acessada por todos
    public Allergies(int mask)
    {
        auxMask = mask; //passando o valor de alergies que é interno para auxMask que é geral
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return List().Contains(allergen);// olha se possui a alergia informada na lista
    }

    public Allergen[] List()
    {
        List<Allergen> individualAllergies = new List<Allergen>();//lista para os alergicos informados pelo indivíduo
        foreach(var allergy in Enum.GetValues(typeof(Allergen)))//cada alergico possível, verifica se o valor em bin pertence ao valor informado
        {
            if ((auxMask & (int)allergy) > 0) individualAllergies.Add((Allergen)allergy);//se sim, colocar na lista da pessoa
        }
        return individualAllergies.ToArray();//retorna a lista do cidadão que será utilizada no isallergicto

    }
}