using LogicalProgrampracties.ArrayLogicalProgram;
using LogicalProgrampracties.Collection;
using LogicalProgrampracties.LinkedList;
using LogicalProgrampracties.Pattern;
using LogicalProgrampracties.Queue;
using LogicalProgrampracties.SortingAlgorithm;
using LogicalProgrampracties.Stack;
using LogicalProgrampracties.StringLogicalProgram;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrampracties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Your Choice " +
                "\n1.PalindromeNumber" +
                "\n2.reverseNumber" +
                "\n3.Primeno" +
                "\n4.FactorialNumber" +
                "\n5.PerfectNumber" +
                "\n6.Fibonacciseries" +
                "\n7.AmstrongNumber" +
                "\n8.SumOfDigit" +
                "\n9.SwapNumber" +
                "\n10.BinaryToDecimal" +
                "\n11.Fibonacci triangle" +
                "\n12.EvenOddposition" +
                "\n13:SumOFArray" +
                "\n14 MinMaxArray" +
                "\n15.SortArray" +
                "\n16.CopyArray" +
                "\n17.FindDuplicate" +
                "\n18.EvenoddElement" +
                "\n19.Frequency of Element" +
                "\n20.RemoveDuplicate" +
                "\n21.StringReverse" +
                "\n22.FindDuplicateElementinString" +
                "\n23.SortString+" +
                "\n24.CountNumberOfWord" +
                "\n25.SpecialChar" +
                "\n26 .LinkedList" +
                "\n27. Stack"+
                "\n28.Queue"+
                "\n29.BubbleSort"+
                "\n30.SelectionSort"+
                "\n31.InsertionSort"+
                "\n32.Pattern"+
                "\n33.frequenyOfchar"+
                "\n34.FindDuplicate"+
                "\n35 .LinkedListCollection"+
                "\n36.SortedList"+
                "\n37.Dictionary"+
                "\n38.MinMaxInStack"+
                "\n39.FrequencyOfCharindic"+
                "\n40.Hashset"+
                "\n41.RemoveDuplicate"+
                "\n42.Addressbook"+
                "\n43.EmployeeInDic"+
                "\n44.SeprateIndivialChar"+
                "\n45.RemoveSpecialChar"

                );
                int ch = Convert.ToInt32(Console.ReadLine());
           
                switch(ch)
                {
                    case 1:
                        PalindromeNumber palindromeNumber = new PalindromeNumber();
                        palindromeNumber.palindrome();
                        Console.ReadLine();
                        break;
                    case 2:

                        revserseNumber revserseNumber = new revserseNumber();
                        revserseNumber.Reverse();
                        Console.ReadLine();
                        break;
                    case 3:

                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.prime();
                        Console.ReadLine();
                        break;
                    case 4:

                        FactorialNumber factorialNumber = new FactorialNumber();
                        factorialNumber.Fact();
                        Console.ReadLine();
                        break;
                    case 5:
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.perferctNo();
                        Console.ReadLine();
                        break;
                    case 6:
                        FibonacciSeries  fibonacciSeries = new FibonacciSeries();
                        fibonacciSeries.Fibonacci();
                        Console.ReadLine();
                        break;
                    case 7:
                        AmstrongNo amstrongNo = new AmstrongNo();
                        amstrongNo.findAmstrongNo();
                        Console.ReadLine();
                        break;
                    case 8:
                        SumOfDigit sumOfDigit = new SumOfDigit();
                        sumOfDigit.FindSumOfDigit();
                        Console.ReadLine();
                        break;
                    case 9:
                        SwapTwoNumberWithoutthirdvariable swapTwoNumber = new SwapTwoNumberWithoutthirdvariable();
                        swapTwoNumber.swap();
                        Console.ReadLine();
                        break;
                    case 10:
                        BinaryToDecimal binaryToDecimal = new BinaryToDecimal();
                        binaryToDecimal.ConvertBinaryToDecimal();
                        Console.ReadLine();
                        break;
                    case 11:
                        FibonaacciSeriresTriangle seriresTriangle = new FibonaacciSeriresTriangle();
                        seriresTriangle.FibTraingle();
                        Console.ReadLine();
                        break;
                    case 12:
                        EvenOddArrayElement evenOddArrayElement = new EvenOddArrayElement();
                        evenOddArrayElement.FindEvenOddArrayPositionElement();
                        Console.ReadLine();
                        break;
                    case 13:
                        SumArrayElement sumArray = new SumArrayElement();
                        sumArray.SumOfArry();
                        Console.ReadLine();
                        break;
                    case 14:
                        MinMaxNo minMaxNo = new MinMaxNo();
                        minMaxNo.MinMax();
                        Console.ReadLine();
                        break;
                    case 15:
                        SortingArrayElement sortingArray = new SortingArrayElement();
                        sortingArray.sort();
                        sortingArray.desending();
                        Console.ReadLine();
                        break;
                    case 16:
                        CopyArray copyArray = new CopyArray();
                        copyArray.Copy();
                        Console.ReadLine();
                        break;
                    case 17:
                        FindDuplicateArray findDuplicate = new FindDuplicateArray();
                        findDuplicate.FindDuplicateElement();
                        Console.ReadLine();
                        break;

                    case 18:
                        OddEvenElement oddEvenElement = new OddEvenElement();
                        oddEvenElement.EvenOdd();
                        Console.ReadLine();
                        break;
                    case 19:
                        FrequencyofElement frequencyofElement = new FrequencyofElement();
                        frequencyofElement.feqword();
                        Console.ReadLine();
                        break;
                    case 20:
                        RemoveDuplicate removeDuplicate = new RemoveDuplicate();
                        removeDuplicate.RemoveDuplicateElement();
                        Console.ReadLine();
                        break;
                    case 21:
                        StringReverse stringReverse = new StringReverse();
                        stringReverse.stringRev();
                        Console.ReadLine();
                        break;
                    case 22:
                        FindDuplicateElement findDuplicate1 = new FindDuplicateElement();
                        findDuplicate1.FindDuplicate();
                        Console.ReadLine();
                        break;
                    case 23:
                        SortStringInAlphabiticalOrder sortString = new SortStringInAlphabiticalOrder();
                        sortString.AlphabiticalOrder();
                        Console.ReadLine();
                        break;

                    case 24:
                        Countword countword = new Countword();
                        countword.word();
                        Console.ReadLine();
                        break;
                    case 25:
                        findSpecialChar findSpecialChar = new findSpecialChar();
                        findSpecialChar.speicalchar();
                        Console.ReadLine();
                        break;
                    case 26:
                        LinkedListMethod linkedList = new LinkedListMethod();
                        linkedList.AddFirst("va");
                        linkedList.AddFirst("su");
                        linkedList.Display();
                        linkedList.AddLast("shiv");
                        linkedList.Display();
                        linkedList.AddLast("vasu");
                        linkedList.RemoveFirst();
                        linkedList.Display();
                        linkedList.findRemoveLast();
                        linkedList.Display();
                        Console.ReadLine();
                        break;
                    case 27:
                        stackMethod stack = new stackMethod();
                        stack.Push(10);
                        stack.Push(20);
                        stack.Push(30);
                        stack.display();
                        stack.pop();
                        stack.display();
                        stack.peek();
                        stack.display();
                        Console.ReadLine();
                        break;
                    case 28:
                        QueueMethod queueMethod = new QueueMethod();
                        queueMethod.Enque(10);
                        queueMethod.Enque(20);
                        queueMethod.Enque(30);
                        queueMethod.display();
                        queueMethod.deque();
                        queueMethod.display();
                        Console.ReadLine();
                        break;
                    case 29:
                        BubbleSort bubbleSort = new BubbleSort();
                        bubbleSort.B_sort();
                        Console.ReadLine();
                        break;
                    case 30:
                        SelectionSort selectionSort = new SelectionSort();
                        selectionSort.FindSelectionSort();
                        Console.ReadLine();
                        break;
                    case 31:
                        InsertionSort insertionSort = new InsertionSort();
                        insertionSort.Sort();
                        Console.ReadLine();
                        break;
                    case 32:

                        Pattern1 pattern1 = new Pattern1();
                        pattern1.pattern1();
                        pattern1.Pattern2();
                        pattern1.pattern3();
                        pattern1.pattern4();
                        pattern1.Pattern5();
                        pattern1.pattern6();
                        Console.ReadLine();
                        break;
                    case 33:
                        FoundNoinArray frequencyofchar = new FoundNoinArray();
                        frequencyofchar.Frequency();
                        Console.ReadLine();
                        break;
                    case 34:
                        FindDuplicate findDuplicate2 = new FindDuplicate();
                        findDuplicate2.FindDuplicateElement();
                        Console.ReadLine();
                        break;
                    case 35:
                        LinkedListCollectio linkedListCollectio = new LinkedListCollectio();
                        linkedListCollectio.ListExample();
                        Console.ReadLine();
                        break;
                    case 36:
                        SortedList sorted = new SortedList();
                        sorted.sortedList();
                        Console.ReadLine();
                        break;
                    case 37:
                        Dictionary11 dictionary11 = new Dictionary11();
                        dictionary11.FindDictionary();
                        Console.ReadLine();
                        break;
                    case 38:
                        StackMinMax stackMinMax = new StackMinMax();
                        stackMinMax.MinMaxno();
                        Console.ReadLine();
                        break;
                    case 39:
                        Frequencyofcharindictionary frequencyofcharindictionary = new Frequencyofcharindictionary();
                        frequencyofcharindictionary.FeqOfcharInDic();
                        Console.ReadLine();
                        break;
                    case 40:
                        Hashset hashset = new Hashset();
                        hashset.RemoveDuplicate();
                        Console.ReadLine();
                        break;
                    case 41:
                        RemoveDuplicateinstring removeDuplicateinstring = new RemoveDuplicateinstring();
                        removeDuplicateinstring.RemoveDuplicateChar();
                        Console.ReadLine();
                        break;
                    case 42:
                        AddressBook addressBook = new AddressBook();
                        AddressBook.Add();
                        AddressBook.display();
                        Console.ReadLine();
                        break;
                    case 43:
                        EmpAddressBook empAddressBook = new EmpAddressBook();
                        empAddressBook.add();
                        Console.ReadLine();
                        break;
                    case 44:
                        SeprateIndiviualCharacter seprateIndiviualCharacter = new SeprateIndiviualCharacter();
                        seprateIndiviualCharacter.SeprateIndiviualChar();
                        Console.ReadLine();
                        break;
                    case 45:
                        RemoveSpecialChar removeSpecialChar = new RemoveSpecialChar();
                        removeSpecialChar.removespecialchar();
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("wrong input given...please enter correct one");
                        break;
                }
                flag = false;
                Console.WriteLine("Try Again ");
                break;
            }
               
            }
            
     
        
    }
}
