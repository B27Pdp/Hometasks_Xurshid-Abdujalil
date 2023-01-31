using System;
namespace OOP_L1
{
	namespace OliyTalim_Fan_Innovatsiyalar_Vazirligi
	{
		namespace OliyTalim_Vazirligi
		{
			namespace Institutlar
			{
				class Economics
				{

					public static int budget_allocated = 660000;
					public static short numberOf_TotalStudents = 11000;
					public static short numberOf_GrantStudents = 3000;
					public static short numberOf_PayingStudents = 8000;
					public static ushort ContractSum = 1000;
					public static short teachers = 800;
					static int Salary_teachers = (int)teachers * 400;


					public class Accounting
					{

						void Income_Tuitionfee()
						{
							int Paid_TuitionFee = numberOf_PayingStudents * ContractSum;


							Console.WriteLine($"Jami kontract to'landi :  {Paid_TuitionFee} ");
						}

						public void Expense_salaryTo_teachers()
						{

							Console.WriteLine($"Oqituvchilarga sarflanayotgan mablag' {Salary_teachers} ");
						}
						void Reserve_Budget()
						{
							Console.WriteLine(budget_allocated - Salary_teachers);
						}

					}



				}

			}

			namespace Fan_Vazirligi
			{
				class Fan_Vazirligi
				{

				}
			}
			namespace Innovatsiyalar_Vazirligi
			{
				class Innovation_Vazirligi
				{
					int number_of_members;
					public static void Nimadur_Qiladi()
					{
						Console.WriteLine("We do smth that nobody understands");
					}


				}
			}

		}
	}
}