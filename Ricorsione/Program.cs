/*
    Esercizi Base
Conteggio regressivo: scrivi una funzione ricorsiva ConteggioRegressivo(int n) che stampi i numeri da n a 1.
    Somma dei primi N numeri: scrivi una funzione ricorsiva SommaN(int n) che calcoli la somma dei primi n numeri naturali.
    Potenza: scrivi una funzione ricorsiva Potenza(int base, int esponente) che calcoli base^esponente.
    Cifre di un numero: scrivi una funzione ricorsiva ContaCifre(int n) che restituisca il numero di cifre in n.
    Esercizi Intermedi
Massimo in un array: scrivi una funzione ricorsiva TrovaMassimo(int[] arr, int i) che trovi il valore massimo in un array, partendo dall'indice i.
    Inversione di una stringa: scrivi una funzione ricorsiva InvertiStringa(string s) che inverta una stringa.
    Palindromo: scrivi una funzione ricorsiva IsPalindromo(string s) che verifichi se una stringa è palindroma, cioè si legge allo stesso modo da sinistra a destra e da destra a sinistra.
    MCD (Massimo Comun Divisore): scrivi una funzione ricorsiva MCD(int a, int b) che calcoli il massimo comun divisore usando l'algoritmo di Euclide.
*/

void ConteggioRegressivo(int n)
{
    Console.WriteLine(n);
    // caso base
    if (n == 1) return;
    // caso ricorsivo
    ConteggioRegressivo(n - 1);
}

int SommaN(int n)
{
    return n + (n == 1 ? 0 : SommaN(n - 1));
}

int Potenza(int baseNum, int esponente) {
    
    return (esponente == 0) ? 1 : baseNum * Potenza(baseNum, esponente - 1);
}

int ContaCifre(int n)
{
    if (n == 0) return 0;

    return 1 + ContaCifre(n / 10);
}

ConteggioRegressivo(6);
Console.WriteLine("Somma dei primi 3 numeri naturali: " + SommaN(3));
Console.WriteLine(Potenza(3, 3));
Console.WriteLine(ContaCifre(-123));
