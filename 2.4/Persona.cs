using System;

public class Persona{
    private string nombre;
    private int edad;
    private string sexo;
    private double altura;
    private double peso;

    public Persona()
    {
        nombre = "";
        edad = altura = peso = 0;
    }
    public Persona(string nombre, int edad,string sexo, double altura,double peso)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.sexo = sexo;
        this.altura = altura;
        this.peso = peso;
    }
    public string pNombre
    {
        set { nombre = value; }
        get { return nombre; }
    }
    public int pEdad
    {
        set { edad = value; }
        get { return edad; }
    }
    public string pSexo
    {
        set { sexo = value; }
        get { return sexo; }
    }
    public double pAltura
    {
        set { altura = value; }
        get { return altura; }
    }
    public double pPeso
    {
        set { peso = value; }
        get { return peso; }
    }
}
