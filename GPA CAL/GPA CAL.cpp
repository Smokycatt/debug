#include <iostream>

int main()
{
    

    system("CLS");

    //declaring variables
    double gpa = 0;
    int grade = 0;
    int clas = 0;
    int repeater = 0;
    char weight = 'n';
    int weights = 0;
    

    std::cout << "Hello and welcome to Mark's gpa couclator \nplease type the number of class's you have ";
    std::cin >> clas;
    system("CLS");
    
    while (repeater != clas)
    {
        repeater += 1;
        std::cout << "please put in if it's a weighted class (press w) or a normal class (press n) ";
        std::cin >> weight;

        if (weight == 'w')
        {
            weights += 1;

        }
            

        std::cout << " \n grade";
        std::cin >> grade;

        if (grade < 65)
        {
            grade = 0;
        }
        else if (grade >= 65 & grade < 70) 
        {
            grade = 1;
        }
        else if (grade >= 70 & grade < 80)
        {
            grade = 2;
        }
        else if (grade >= 80 & grade < 90)
        {
            grade = 3;
        }
        else if (grade >= 90)
        {
            grade = 4;
        }

        gpa += grade;

        system("CLS");

    }
    gpa += weights;

    double G = gpa / clas;
    
    std::cout << "your G.P.A. is  " ;
    std::cout << G;

}

