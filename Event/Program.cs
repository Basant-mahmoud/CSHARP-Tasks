namespace Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department dept = new Department { DeptID = 1, DeptName = "IT" };
            Club club = new Club { ClubID = 1, ClubName = "Company Club" };

            // Normal (عنده اجازات)
            Employee emp1 = new Employee
            {
                EmployeeID = 101,
                BirthDate = new DateTime(1970, 1, 1), 
                VacationStock = 5
            };

            // Create SalesPerson
            SalesPerson sales = new SalesPerson
            {
                EmployeeID = 201,
                BirthDate = new DateTime(1985, 5, 5), 
                AchievedTarget = 50
            };

            // Create BoardMember
            BoardMember bm = new BoardMember
            {
                EmployeeID = 301,
                BirthDate = new DateTime(1950, 3, 3) // عنده 74 سنة (بس مش هيتشال)
            };

            // Add to Department + Club
            dept.AddStaff(emp1);
            dept.AddStaff(sales);
            dept.AddStaff(bm);

            club.AddMember(emp1);
            club.AddMember(sales);
            club.AddMember(bm);

            Console.WriteLine("=== Start Testing ===");

            // 1) Request vacation أكتر من الرصيد → يتشال من Dept + Club
            Console.WriteLine("\n[Employee takes long vacation]");
            emp1.RequestVacation(DateTime.Now, DateTime.Now.AddDays(10));

            // 2) Check Target للسيلز (لو أقل من Quota يتشال)
            Console.WriteLine("\n[SalesPerson check target]");
            sales.CheckTarget(100); // مطلوب 100 وهو محقق 50

            // 3) EndOfYearOperation (السن > 60) → يتشال من Department بس مش من Club
            Console.WriteLine("\n[End of Year check]");
            emp1.EndOfYearOperation();  // سنه 55 (مش هيتشال)
            bm.EndOfYearOperation();    // سنه 74 بس BoardMember مش بيتشال

            // 4) BoardMember Resigns
            Console.WriteLine("\n[BoardMember resigns]");
            bm.Resgin();

            Console.WriteLine("\n=== End Testing ===");
        }
    }
}
