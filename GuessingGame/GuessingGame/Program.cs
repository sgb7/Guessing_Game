using System;

namespace BinaryTreeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Animal Guessing Game\n");

            BinaryTree binaryTree = new BinaryTree();

            binaryTree.insert("Is it a cat?\n", "");
            binaryTree.display();

            string correctOrIncorrect;
            string actualAnimal;
            string newQuestion;
            string yesOrNo;
            string continuePlaying = "";

            while(continuePlaying != "no")
            {
                //print root
                correctOrIncorrect = Console.ReadLine();
                if (correctOrIncorrect == "yes")
                {
                    Console.WriteLine("Hooray! I win! :)");
                    Console.WriteLine("Would you like to play again?");
                    continuePlaying = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("What animal were you thinking of then?");
                    actualAnimal = Console.ReadLine();

                    Console.WriteLine("Could you provide a yes or no question to help differentiate this animal?");
                    newQuestion = Console.ReadLine();

                    Console.WriteLine("Is the answer to this question yes or no?");
                    yesOrNo = Console.ReadLine();

                    Console.WriteLine("Would you like to play again?");
                    continuePlaying = Console.ReadLine();
                }
            }

            /*binaryTree.insert("Hello");
            binaryTree.insert("This");
            binaryTree.insert("Is");
            binaryTree.insert("A");
            binaryTree.insert("Test.");
            //binaryTree.display();*/
        }
    }
}
