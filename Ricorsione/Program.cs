// Esercizi di ricorsione


// Esercizi BASE
/*Conteggio regressivo: scrivi una funzione ricorsiva ConteggioRegressivo(int n) che stampi i numeri da n a 1.*/
void ConteggioRegressivo(int n)
{
    Console.WriteLine(n);
    if (n == 1) return; // caso base
    ConteggioRegressivo(n - 1);// caso ricorsivo
}

/*Somma dei primi N numeri: scrivi una funzione ricorsiva SommaN(int n) che calcoli la somma dei primi n numeri naturali.*/
int SommaN(int n)
{
    return n + (n == 1 ? 0 : SommaN(n - 1));
}

/*Potenza: scrivi una funzione ricorsiva Potenza(int base, int esponente) che calcoli base^esponente.*/
int Potenza(int baseNum, int esponente) {
    
    return (esponente == 0) ? 1 : baseNum * Potenza(baseNum, esponente - 1);
}

/*Cifre di un numero: scrivi una funzione ricorsiva ContaCifre(int n) che restituisca il numero di cifre in n.*/
int ContaCifre(int n)
{
    return n == 0 ? 0 : 1 + ContaCifre(n / 10);
}



// Esercizi INTERMEDI
/*Inversione di una stringa: scrivi una funzione ricorsiva InvertiStringa(string s) che inverta una stringa.*/
string InvertiStringa(string s)
{
    if (s.Length <= 1) return s;

    return s[s.Length - 1] + InvertiStringa(s.Substring(0, s.Length - 1));
}

/*Palindromo: scrivi una funzione ricorsiva IsPalindromo(string s) che
verifichi se una stringa è palindroma, cioè si legge allo stesso modo da sinistra a destra e da destra a sinistra.*/
bool IsPalindromo(string s)
{
    if (s.Length <= 1) return true;

    if (s[0] != s[s.Length - 1]) return false;

    return IsPalindromo(s.Substring(1, s.Length - 2));
}

/*MCD (Massimo Comun Divisore): scrivi una funzione ricorsiva MCD(int a, int b) che calcoli il massimo comun divisore usando l'algoritmo di Euclide.*/
int MCD(int a, int b)
{
    if(a < b) 
        (a, b) = (b, a); // scambia a e b se a è minore di b

    if(a % b == 0) return b; // caso base
    return MCD(b, a % b); // caso ricorsivo
}



ConteggioRegressivo(6);
Console.WriteLine("Somma dei primi 3 numeri naturali: " + SommaN(3));
Console.WriteLine(Potenza(3, 3));
Console.WriteLine(ContaCifre(-123));
Console.WriteLine(InvertiStringa("Ciao"));
Console.WriteLine(IsPalindromo("cocco"));
Console.WriteLine(MCD(18, 48));
