namespace MyfirstAPI.Entities;

public abstract class Device//Abstract faz com que não seja possível criar um objeto device, somente objetos das classes dervidas de device
{
    protected bool IsConnected() => true;// Protected só permitirá acesso no filho imediato desta classe
    public abstract string GetBrand();//Obriga as classes filhas a implementarem essa função
    
    public virtual string Hello()//Virtual permite que as classes dervidas possam sobrescrever essa função
    {
        return "Olá";
    }

}
