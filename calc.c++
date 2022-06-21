#include <iostream>
int main()
{
  std::cout << "Enter number 1: " << std::endl ;
  float a;
  float b;
  int act;
  std::cin >> a;
  std::cout << "(1)Addition" << std::endl << "(2)Subtraction" << std::endl << "(3)Multiplication" << std::endl << "(4)Separation" << std::endl << "Enter action(index): " << std::endl;
  std::cin >> act;
  std::cout << "Enter number 2:" << std::endl;
  std::cin >> b;
  if (act == 1){
    std::cout << "ANSWER" << std::endl << a + b << std::endl;
  }
  if (act == 2){
    std::cout << "ANSWER" << std::endl << a - b << std::endl;
  }
  if (act == 3){
    std::cout << "ANSWER" << std::endl << a * b << std::endl;
  }
  if (act == 4){
    std::cout << "ANSWER" << std::endl << a / b << std::endl;
  }
  return 0;
}