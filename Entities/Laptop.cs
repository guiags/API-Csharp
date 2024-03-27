using System.Globalization;

namespace MyfirstAPI.Entities;

public sealed class Laptop : Device // Faz com que laptop esteja impossibilitada de se tornar uma classe pai
{
    //override sobrescreve a função
    public override string GetBrand() // Classe obrigatoria devido ao abstract da classe pai
    {
        return "Notebook";
    }

    public override string Hello()//Permite sobrescreve pois a função original da classe bas e é virtual
    {
        return "Olá  Sexta";
    }

    public string GetModel()
    {
        var isConnected = IsConnected();
        if (isConnected)
        {
            return "HP";
        }
        return "Unknown";
    }
}
