using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace set3
{
    internal class Program
    {
        private static void MENU()
        {
            Console.WriteLine($"1.Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.\r\n2.Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1. \r\n3.Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz).\r\n4.Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. \r\n5.Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero. \r\n6.Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga. \r\n7.Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.\r\n8.Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. \r\n9.Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga. \r\n10.Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1.\r\n11.Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene).\r\n12.Sortare selectie. Implementati algoritmul de sortare <Selection Sort>.\r\n13.Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>. \r\n14.Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului). \r\n15.Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. \r\n16.Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.\r\n17.Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.   \r\n18.Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. Cel mai putin semnificativ coeficient este pe pozitia zero in vector. Se cere valoarea polinomului intr-un punct x. \r\n19.Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori apare p in s. De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. (Problema este dificila doar daca o rezolvati cu un algoritm liniar).\r\n20.Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare. Siragurile de margele se pot roti atunci cand le suprapunem.\r\n21.Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar).\r\n22.Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat. \r\n23.Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2  sunt in ordine strict crescatoare. \r\n24.Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori cu valori binare (v[i] este 1 daca i face parte din multime si este 0 in caz contrar).\r\n25.(Interclasare) Se dau doi vector sortati crescator v1 si v2. Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2. Sunt permise elemente duplicate. \r\n26.Se dau doua numere naturale foarte mari (cifrele unui numar foarte mare sunt stocate intr-un vector - fiecare cifra pe cate o pozitie). Se cere sa se determine suma, diferenta si produsul a doua astfel de numere. \r\n27.Se da un vector si un index in vectorul respectiv. Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat. \r\n28.Quicksort. Sortati un vector folosind metoda QuickSort. \r\n29.MergeSort. Sortati un vector folosind metoda MergeSort.\r\n30.Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i]. Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima. \r\n31.(Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate daca mai mult de n/2 din valorile vectorului sunt egale cu m (prin urmare, daca un vector are element majoritate acesta este unui singur).  Sa se determine elementul majoritate al unui vector (daca nu exista atunci se va afisa <nu exista>). (incercati sa gasiti o solutie liniara). \r\n");
        }
        /// <summary>
        /// Suma elementtelor din vector.
        /// </summary>
        private static void P1()
        {
            Console.WriteLine("1.Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.");
            Console.Write("Introduceti lungimea vectorului:");
            int n = int.Parse(Console.ReadLine());
            string[] t = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            int suma = 0;
            int i;
            for (i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
                suma = suma + v[i];
            }
            Console.WriteLine("Suma este egala cu:" + suma);
            Intoarcere();
        }
        /// <summary>
        /// Prima pozitie pe care apare k in vector.
        /// </summary>
        private static void P2()
        {
            Console.WriteLine("2.Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1.");
            Console.Write("Introduceti lungimea vectorului:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti k:");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti vectorul:");
            string[] t = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            bool ok = false;
            for (int i = 0; i < n; i++)
                if (v[i] == k)
                {
                    Console.WriteLine(i); ok = true;
                    break;
                }
            if (!ok)
                Console.WriteLine("-1");
        }
        /// <summary>
        /// Pozitiile pe care apar cel mai mic si cel mai mare element.
        /// </summary>
        private static void P3()
        {
            Console.WriteLine("3.Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz).");
            Console.WriteLine("Introduceti vectorul:");
            string[] t = Console.ReadLine().Split(' ');
            int[] v = new int[t.Length];
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            int minpos = 0, maxpos = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] < v[minpos])
                    minpos = i;
                if (v[i] > v[maxpos])
                    maxpos = i;
            }
            Console.WriteLine("Minimul se afla pe pozitia " + minpos);
            Console.WriteLine("Maximul se afla pe pozitia " + maxpos);
            Intoarcere();
        }
        /// <summary>
        /// Min si max printr-o singura pozitie + contorizare.
        /// </summary>
        private static void P4()
        {
            Console.WriteLine("4.Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea.");
            Console.WriteLine("Introduceti vectorul:");
            string[] t = Console.ReadLine().Split(' ');
            int[] v = new int[t.Length];
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            int min = v[0], max = v[0];
            int mincount = 1, maxcount = 1;
            for (int i = 1; i < v.Length; i++)
            {
                if (v[i] < min)
                {
                    min = v[i];
                    mincount = 1;
                }
                else if (v[i] == min)
                {
                    mincount++;
                }
                if (v[i] > max)
                {
                    max = v[i];
                    maxcount = 1;
                }
                else if (v[i] == max)
                {
                    maxcount++;
                }
            }

            Console.WriteLine("Minimul este " + min + " si apare de " + mincount + " ori");
            Console.WriteLine("Maximul este " + max + " si apare de " + maxcount + " ori");
            Intoarcere();
        }
        /// <summary>
        /// Inseram e pe pozitia k.
        /// </summary>
        private static void P5()
        {
            Console.WriteLine("5.Se da un vector cu n elemente, o valoare e si o pozitie din vector k.Se cere sa se insereze valoarea e in vector pe pozitia k.Primul element al vectorului se considera pe pozitia zero.");
            Console.Write("Introduceti valoarea e:");
            int e = int.Parse(Console.ReadLine());
            Console.Write("Introduceti pozitia k:");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti vectorul:");
            string[] t = Console.ReadLine().Split(' ');
            int[] v = new int[t.Length];
            int[] T = new int[t.Length + 1];
            int i;
            for (i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            i = 0;
            while (i < k)
            {
                T[i] = v[i]; i++;
            }
            T[k] = e; i++;
            while (i < T.Length)
            {
                T[i] = v[i - 1]; i++;
            }
            PrintArray(T);
            Intoarcere();
        }
        /// <summary>
        /// Stergere element de pe pozitia k.
        /// </summary>
        private static void P6()
        {
            Console.WriteLine("6.Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga.");
            Console.WriteLine("Introduceti pozitia k:");
            Console.WriteLine("Introduceti vectorul:");
            int k = int.Parse(Console.ReadLine());
            string[] t = Console.ReadLine().Split(' ');
            int[] v = new int[t.Length];
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            int length = v.Length;
            for (int i = k + 1; i < length; i++)
            {
                v[i - 1] = v[i];
            }
            length--;
            PrintArray(v);
            Intoarcere();
        }
        /// <summary>
        /// Reverse vector.
        /// </summary>
        private static void P7()
        {
            Console.WriteLine("7.Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.");
            Console.WriteLine("Introduceti vectorul:");
            string[] t = Console.ReadLine().Split(' ');
            int[] v = new int[t.Length];
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            int n = v.Length;
            int mij = n / 2;
            for (int i = 0; i < mij; i++)
            {
                int temp = v[i];
                v[i] = v[n - i - 1];
                v[n - i - 1] = temp;
            }
            PrintArray(v);
            Intoarcere();
        }
        /// <summary>
        /// Rotire elemente vector cu o pozitie la stanga.
        /// </summary>
        private static void P8()
        {
            Console.WriteLine("Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc.");
            Console.WriteLine("Introduceti vectorul:");
            string[] t = Console.ReadLine().Split(' ');
            int[] v = new int[t.Length];
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            int aux = v[0];
            for (int i = 0; i < v.Length - 1; i++)
            {
                aux = v[i];
                v[i] = v[i + 1];
                v[i + 1] = aux;
            }
            PrintArray(v);
            Intoarcere();
        }
        /// <summary>
        /// Rotire elementele vector cu k pozitii spre stanga.
        /// </summary>
        private static void P9()
        {
            Console.WriteLine("9.Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga.");
            Console.Write("Introduceti k:");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti vectorul:");
            string[] t = Console.ReadLine().Split(' ');
            int[] v = new int[t.Length];
            k = v.Length - (k % v.Length);
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            int n = v.Length;
            int[] s = new int[v.Length];
            Array.Copy(v, s, v.Length);
            for (int i = 0; i < n; i++)
            {
                int newpos = (i - k) % n;
                if (newpos < 0)
                {
                    newpos += n;
                }
                v[i] = s[newpos];
            }
            Console.WriteLine("Vectorul rotit:");
            foreach (int x in v)
            {
                Console.Write(x + " ");
            }
            Intoarcere();
        }
        /// <summary>
        /// Gasim pozitia lui k.
        /// </summary>
        private static void P10()
        {
            Console.WriteLine("10. Cautare binara.Se da un vector cu n elemente sortat in ordine crescatoare.Se cere sa se determine pozitia unui element dat k.Daca elementul nu se gaseste in vector rezultatul va fi - 1.");
            Console.WriteLine("Introduceti vectorul:");
            string[] t = Console.ReadLine().Split(' ');
            int[] v = new int[t.Length];
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            Array.Sort(v);
            Console.Write("Dati elementul 'k': ");
            int k = int.Parse(Console.ReadLine());
            int kpoz = -1;
            Console.Write("K se afla pe pozitia : ");
            int stg, dr, mij;
            stg = 0;
            dr = v.Length - 1;
            while (stg <= dr)
            {
                mij = (stg + dr) / 2;
                if (v[mij] < k)
                    stg = mij + 1;
                else if (v[mij] > k)
                    dr = mij - 1;
                else
                {
                    Console.Write(mij);
                    return;
                }
            }
            Console.Write(kpoz);
        }
        /// <summary>
        /// Ciurul lui Eratostene.
        /// </summary>
        private static void P11()
        {
            Console.WriteLine("11.Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene).");
            // citim valoarea maxima
            Console.Write("Introduceti n:");
            string input = Console.ReadLine();
            int maxValue = int.Parse(input);
            List<int> numbers = Enumerable.Range(2, maxValue - 1).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                int prim = numbers[i];
                numbers.RemoveAll(x => x % prim == 0 && x != prim);
            }
            List<int> primes = numbers;
            foreach (int prime in primes)
            {
                Console.Write(prime);
            }
            Intoarcere();
        }
        /// <summary>
        /// Selection sort.
        /// </summary>
        private static void P12()
        {
            Console.WriteLine("12.Sortare selectie. Implementati algoritmul de sortare <Selection Sort>.");
            var array = ReadArray();
            SelectionSort(array);
            Console.WriteLine($"Vectorul dupa sortare: {String.Join(" ", array)}");
            Intoarcere();
        }

        private static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                    if (array[j] < array[minIndex])
                        minIndex = j;
                (array[i], array[minIndex]) = (array[minIndex], array[i]);
            }
        }
        /// <summary>
        /// Insertion sort.
        /// </summary>
        private static void P13()
        {
            Console.WriteLine("13.Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>.");
            Console.Write("Introduceti lungimea vectorului:");
            int n = int.Parse(Console.ReadLine());
            string[] t = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            int aux;
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(t[i]);
                for (int k = i; k > 0 && v[k] < v[k - 1]; k--)
                {

                    aux = v[k]; v[k] = v[k - 1]; v[k - 1] = aux;
                }
            }
            PrintArray(v);
            Intoarcere();
        }
        /// <summary>
        /// Afisam vectorul cu elementele egale cu 0 la final.
        /// </summary>
        private static void P14()
        {
            Console.WriteLine("14. Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului).");
            Console.WriteLine("Introduceti vectorul:");
            string[] t = Console.ReadLine().Split(' ');
            int[] v = new int[t.Length];
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            int max = v.Length;
            for (int i = 0; i < max; i++)
            {
                while (v[i] == 0)
                {
                    max--;
                    for (int j = i; j < max; j++)
                    {
                        (v[j], v[j + 1]) = (v[j + 1], v[j]);
                    }
                }
            }
            Console.WriteLine("Elementele 0 transpuse la final: ");
            PrintArray(v);
            Intoarcere();
        }
        /// <summary>
        /// Eliminare elemente care se repeta fara a folosi alt vector.
        /// </summary>
        private static void P15()
        {
            Console.WriteLine("15.Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector.");
            Console.WriteLine("Introduceti vectorul:");
            string[] t = Console.ReadLine().Split(' ');
            int[] v = new int[t.Length];
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            int max = v.Length - 1;
            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (v[i] == v[j])
                    {
                        v[i] = 0;
                        (v[i], v[max]) = (v[max], v[i]);
                        while (v[i] == 0)
                        {
                            (v[i], v[max]) = (v[max], v[i]);
                            max--;
                        }
                        j = -1;
                    }
                }
            }
            Array.Resize(ref v, max + 1);
            PrintArray(v);
            Intoarcere();
        }
        /// <summary>
        ///CMMDC al elementelor vectorului.
        /// </summary>
        private static void P16()
        {
            Console.WriteLine("16.Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.");
            Console.WriteLine("Introduceti vectorul:");
            string[] t = Console.ReadLine().Split(' ');
            int[] arr = new int[t.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(t[i]);
            }
            int cmmdc = arr[0];
            int j = 1;
            while (cmmdc > 1 && j < arr.Length)
            {
                cmmdc = CMMDC(cmmdc, arr[j]);
                j++;
            }
            Console.WriteLine("CMMDC al elementelor este: " + cmmdc);
            Intoarcere();
        }
        private static int CMMDC(int a, int b)
        {
            int r;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;

        }
        /// <summary>
        /// Conversie numar dintr-o baza in alta.
        /// </summary>
        private static void P17()
        {
            Console.WriteLine("17. Se da un numar n in baza 10 si un numar b. 1 < b < 17.Sa se converteasca si sa se afiseze numarul n in baza b.");
            Console.Write("Dati numarul de convertit: ");
            string n = Console.ReadLine();
            int f = int.Parse(n);
            Console.WriteLine("Dati baza dorita: ");
            int b = int.Parse(Console.ReadLine());
            StringBuilder str = new StringBuilder();
            do
            {
                if (f % b < 10)
                {
                    str.Insert(0, f % b);
                }
                else
                {
                    int r = f % b;
                    switch (r)
                    {
                        case 10:
                            str.Insert(0, 'a');
                            break;
                        case 11:
                            str.Insert(0, 'b');
                            break;
                        case 12:
                            str.Insert(0, 'c');
                            break;
                        case 13:
                            str.Insert(0, 'd');
                            break;
                        case 14:
                            str.Insert(0, 'e');
                            break;
                        case 15:
                            str.Insert(0, 'f');
                            break;
                    }
                }
                f /= b;
            } while (f != 0);
            Console.WriteLine($"Numarul convertit in baza {b} este: ");
            Console.Write(str.ToString());
            Intoarcere();


        }
        /// <summary>
        /// Interclasare a doi vectori.
        /// </summary>
        private static void P25()
        {
            Console.WriteLine("25. (Interclasare) Se dau doi vector sortati crescator v1 si v2.Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2.Sunt permise elemente duplicate.");
            Console.WriteLine("Introduceti primul vectorul:");
            string[] t1 = Console.ReadLine().Split(' ');
            int[] v1 = new int[t1.Length];
            for (int i = 0; i < v1.Length; i++)
            {
                v1[i] = int.Parse(t1[i]);
            }
            InsertionSort(v1);
            Console.WriteLine("Introduceti al doilea vector:");
            string[] t2 = Console.ReadLine().Split(' ');
            int[] v2 = new int[t2.Length];
            for (int i = 0; i < v2.Length; i++)
            {
                v2[i] = int.Parse(t2[i]);
            }
            SelectionSort(v2);
            int[] interclasat = Combine(v1, v2);
            PrintArray(interclasat);
            Intoarcere();
        }
        private static int[] Combine(int[] arr1, int[] arr2)
        {
            int[] ToReturn = new int[arr1.Length + arr2.Length];
            int a1 = 0;
            int a2 = 0;
            for (int i = 0; i < ToReturn.Length; i++)
            {
                try
                {
                    if (arr1[a1] >= arr2[a2])
                    {
                        ToReturn[i] = arr2[a2];
                        a2++;
                        continue;
                    }
                    if (arr1[a1] < arr2[a2])
                    {
                        ToReturn[i] = arr1[a1];
                        a1++;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    if (a2 >= arr2.Length)
                    {
                        ToReturn[i] = arr1[a1];
                        a1++;
                    }
                    else
                    {
                        ToReturn[i] = arr2[a2];
                        a2++;
                    }
                }
            }
            return ToReturn;
      

        }
        /// <summary>
        /// Valoarea indexului dupa sortare.
        /// </summary>
        private static void P27()
        {
            Console.WriteLine("27. Se da un vector si un index in vectorul respectiv.Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat.");
            Console.WriteLine("Introduceti vectorul:");
            string[] t = Console.ReadLine().Split(' ');
            int[] v = new int[t.Length];
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            Console.Write("Dati indexul: ");
            int index = int.Parse(Console.ReadLine());
            if (index >= v.Length)
            {
                Console.WriteLine("Index introdus gresit.");
                return;
            }
            InsertionSort(v);
            Console.WriteLine($"{v[index]} este valoarea care se gaseste pe pozitia {index} dupa sortare.");
            Intoarcere();
        }
        /// <summary>
        /// Quick Sort.
        /// </summary>
        private static void P28()
        {
            Console.WriteLine("28.Quicksort. Sortati un vector folosind metoda QuickSort. ");
            var array = ReadArray();
            QuickSort(array, 0, array.Length - 1);
            Console.WriteLine($"Vectorul dupa sortare: {String.Join(" ", array)}");
            Intoarcere();
        }

        private static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int p = partition(array, left, right);
                QuickSort(array, left, p - 1);
                QuickSort(array, p + 1, right);
            }
        }

        private static int partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    (array[i], array[j]) = (array[j], array[i]);
                }
            }
            i++;
            (array[i], array[right]) = (array[right], array[i]);
            return i;
        }
        /// <summary>
        /// Merge Sort.
        /// </summary>
        //!!!TODO
        private static void P29()
        {
            Console.WriteLine("29.MergeSort. Sortati un vector folosind metoda MergeSort.");

        }
        private static void P31()
        {
            Console.WriteLine("31. (Element majoritate).Intr - un vector cu n elemente, un element m este element majoritate daca mai mult de n / 2 din valorile vectorului sunt egale cu m(prin urmare, daca un vector are element majoritate acesta este unui singur).Sa se determine elementul majoritate al unui vector(daca nu exista atunci se va afisa < nu exista >). (incercati sa gasiti o solutie liniara).");
            Console.WriteLine("Introduceti vectorul:");
            string[] t = Console.ReadLine().Split(' ');
            int[] arr = new int[t.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(t[i]);
            }
            int count = 0, candidat = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (count == 0)
                {
                    candidat = arr[i];
                    count = 1;
                }
                else
                {
                    if (arr[i] == candidat)
                        count++;
                    else
                        count--;
                }
            }
            count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == candidat)
                {
                    count++;
                }
            }
            if (count > arr.Length / 2)
            {
                Console.WriteLine($"Element majoritar: {candidat}.");
                return;
            }
            Console.WriteLine("Nu exista.");
        }
        private static void Intoarcere()
        {
            Console.WriteLine("Apasa orice buton pentru a reveni la meniu.\n");
            Console.ReadKey();
            Console.Clear();
        }
        public static void PrintArray(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
        }
        private static int[] ReadArray()
        {
            Console.Write("Introduceti vectorul:");
            int n = int.Parse(Console.ReadLine());

            char[] separators = { ' ', ',', ':', ';' };
            string[] line = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int[] intsLine = Array.ConvertAll(line, int.Parse);
            return intsLine;
        }
        public static void InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int j = i;
                while (j > 0 && arr[j] < arr[j - 1])
                {
                    (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                    j--;
                }
            }
        }
    }
}