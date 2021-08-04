// Demo_C++.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//

#include <iostream>
int number = 10;
int main1()
{

	printf("%d\n", sizeof(char)); // 1
	printf("%d\n", sizeof(short)); // 2
	printf("%d\n", sizeof(int)); // 4
	printf("%d\n", sizeof(long)); // 4/8     
	printf("%d\n", sizeof(long long)); // 8
	printf("%d\n", sizeof(float)); // 4
	printf("%d\n", sizeof(double)); // 8

	printf("%d", number);
	return 0;
}
int fibonaci(int i)
{
	if (i == 0)
	{
		return 0;
	}
	if (i == 1)
	{
		return 1;
	}
	return fibonaci(i - 1) + fibonaci(i - 2);
}

int  main()
{
	int i;
	for (i = 0; i < 10; i++)
	{
		printf("%d\t\n", fibonaci(i));
	}
	return 0;
}
