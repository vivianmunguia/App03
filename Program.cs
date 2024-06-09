MiDelegado f = delegate (int i, string s)
{
    return i + 100;
};

int resultado = f(250, "Es Vaxi Drez");

public delegate int MiDelegado(int i, string s);