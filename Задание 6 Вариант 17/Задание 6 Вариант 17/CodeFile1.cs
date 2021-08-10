using System;
abstract public class TFunction
{
    public int A;
    public TFunction(int NewA)
    {
        A = NewA;
    }
    abstract public int Calc();
}

public class TRavnoS : TFunction
{
    public TRavnoS(int NewA)
        : base(NewA)
    {
    }
    public override int Calc()
    {
        return 3 * A;  
    }
    public override string ToString()
    {
        return "Равносторонний (" + A + ")";
    }
}
public class TRavnoB : TFunction
{
    public int B;
    public TRavnoB(int NewA, int NewB)
        : base(NewA)
    {
        B = NewB;
    }
    public override int Calc()
    {
        return 2 * A + B;
    }
    public override string ToString()
    {
        return "Равнобедренный (" + A + "," + B+ ")";
    }
}
public class TRaznoS : TFunction
{
    public int B;
    public int C;
    public TRaznoS(int NewA, int NewB, int NewC)
        : base(NewA)
    {
        B = NewB;
        C = NewC;
    }
    public override int Calc()
    {
        return A + B + C;
    }
    public override string ToString()
    {
        return "Разносторонний ("+A + "," + B + "," + C+ ")";
    }
}