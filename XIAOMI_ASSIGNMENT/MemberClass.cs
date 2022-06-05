using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace XIAOMI_ASSIGNMENT
{
    class method
    {
        protected ArrayList member_data = new ArrayList();
        protected ArrayList items_data = new ArrayList();

        item itemDetail = new item();

        
        public void getdata()
        {
            
            string choice = "Y";

            do
            {
                item temp_data1 = new item();
                string categoryCode;

                Console.WriteLine("|--------------------------------------------------------------------|");
                Console.WriteLine();
                Console.WriteLine("|-----------------PLEASE SELECT PRODUCTS CATEGORY--------------------|");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                        A - MI PHONES                               |");
                Console.WriteLine("|                        B - SMART DEVICES                           |");
                Console.WriteLine("|                        C - AUDIO                                   |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|--------------------------------------------------------------------|");
                Console.Write("                        CATEGORY CODE: ");
                categoryCode = Console.ReadLine();
                categoryCode = categoryCode.ToUpper();

                switch (categoryCode)
                {
                    case "A":
                        Console.WriteLine("|--------------------------------------------------------------------|");
                        Console.WriteLine();
                        Console.WriteLine("|-----------------------------MI PHONES------------------------------|");
                        Console.WriteLine("|                                                                    |");
                        Console.WriteLine("|-----------------------PLEASE SELECT PRODUCT------------------------|");
                        Console.WriteLine("|                                                                    |");
                        Console.WriteLine("|          CODE             PRODUCT NAME               PRICE         |");
                        Console.WriteLine("|          1000              POCOPHONE                RM1,199        |");
                        Console.WriteLine("|          1001              MI MAX 3                 RM1,079        |");
                        Console.WriteLine("|          1002              MI 8 LITE                RM999          |");
                        Console.WriteLine("|                                                                    |");
                        Console.WriteLine("|--------------------------------------------------------------------|");
                        Console.Write("                        PRODUCT CODE:");
                        temp_data1.itemcode = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");

                        if (temp_data1.itemcode == 1000)
                        {
                            Console.Write("                        PLEASE ENTER QUANTITY: ");                            
                            temp_data1.quantity = Convert.ToInt32(Console.ReadLine());
                            temp_data1.itemname = ("POCOPHONE");
                            temp_data1.price = 1199;
                            temp_data1.totalprice = temp_data1.quantity * 1199;
                            Console.WriteLine("");
                            Console.WriteLine("                        TOTAL PRICE: RM" + temp_data1.totalprice);
                            Console.WriteLine("");

                            temp_data1.Subtotal = temp_data1.Subtotal + (temp_data1.totalprice);
                        }
                        else if (temp_data1.itemcode == 1001)
                        {
                            Console.Write("                        PLEASE ENTER QUANTITY: ");
                            temp_data1.quantity = Convert.ToInt32(Console.ReadLine());
                            temp_data1.itemname = ("MI MAX 3");
                            temp_data1.price = 1079;
                            temp_data1.totalprice = temp_data1.quantity * 1079;
                            Console.WriteLine("");
                            Console.WriteLine("                        TOTAL PRICE: RM" + temp_data1.totalprice);
                            Console.WriteLine("");

                            temp_data1.Subtotal = temp_data1.Subtotal + (temp_data1.totalprice);
                        }
                        else if (temp_data1.itemcode == 1002)
                        {
                            Console.Write("                        PLEASE ENTER QUANTITY: ");
                            temp_data1.quantity = Convert.ToInt32(Console.ReadLine());
                            temp_data1.itemname = ("MI 8 LITE");
                            temp_data1.price = 999;
                            temp_data1.totalprice = temp_data1.quantity * 999;
                            Console.WriteLine("");
                            Console.WriteLine("                        TOTAL PRICE: RM" + temp_data1.totalprice);
                            Console.WriteLine("");

                            temp_data1.Subtotal = temp_data1.Subtotal + (temp_data1.totalprice);
                        }
                        else
                        {
                            Console.WriteLine("                        INVALID CODE");
                        }
                        break;
                    case "B":
                        Console.WriteLine("|--------------------------------------------------------------------|");
                        Console.WriteLine();
                        Console.WriteLine("|---------------------------SMART DEVICES----------------------------|");
                        Console.WriteLine("|                                                                    |");
                        Console.WriteLine("|-----------------------PLEASE SELECT PRODUCT------------------------|");
                        Console.WriteLine("|                                                                    |");
                        Console.WriteLine("|          CODE             PRODUCT NAME               PRICE         |");
                        Console.WriteLine("|          2000              MI DASHCAM                RM249         |");
                        Console.WriteLine("|          2001              VR PLAY                   RM256         |");
                        Console.WriteLine("|          2002              MI BAND 2                 RM82          |");
                        Console.WriteLine("|          2003              MI CAMERA KIT             RM1,099       |");
                        Console.WriteLine("|                                                                    |");
                        Console.WriteLine("|--------------------------------------------------------------------|");
                        Console.Write("                        PRODUCT CODE:");
                        temp_data1.itemcode = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");

                        if (temp_data1.itemcode == 2000)
                        {
                            Console.Write("                        PLEASE ENTER QUANTITY: ");
                            temp_data1.quantity = Convert.ToInt32(Console.ReadLine());
                            temp_data1.itemname = ("MI DASHCAM");
                            temp_data1.price = 249;
                            temp_data1.totalprice = temp_data1.quantity * 249;
                            Console.WriteLine("");
                            Console.WriteLine("                        TOTAL PRICE: RM" + temp_data1.totalprice);
                            Console.WriteLine("");

                            temp_data1.Subtotal = temp_data1.Subtotal + (temp_data1.totalprice);
                        }
                        else if (temp_data1.itemcode == 2001)
                        {
                            Console.Write("                        PLEASE ENTER QUANTITY: ");
                            temp_data1.quantity = Convert.ToInt32(Console.ReadLine());
                            temp_data1.itemname = ("VR PLAY");
                            temp_data1.price = 256;
                            temp_data1.totalprice = temp_data1.quantity * 256;
                            Console.WriteLine("");
                            Console.WriteLine("                        TOTAL PRICE: RM" + temp_data1.totalprice);
                            Console.WriteLine("");

                            temp_data1.Subtotal = temp_data1.Subtotal + (temp_data1.totalprice);
                        }
                        else if (temp_data1.itemcode == 2002)
                        {
                            Console.Write("                        PLEASE ENTER QUANTITY: ");
                            temp_data1.quantity = Convert.ToInt32(Console.ReadLine());
                            temp_data1.itemname = ("MI BAND 2");
                            temp_data1.price = 82;
                            temp_data1.totalprice = temp_data1.quantity * 82;
                            Console.WriteLine("");
                            Console.WriteLine("                        TOTAL PRICE: RM" + temp_data1.totalprice);
                            Console.WriteLine("");

                            temp_data1.Subtotal = temp_data1.Subtotal + (temp_data1.totalprice);
                        }
                             else if (temp_data1.itemcode == 2003)
                        {
                            Console.Write("                        PLEASE ENTER QUANTITY: ");
                            temp_data1.quantity = Convert.ToInt32(Console.ReadLine());
                            temp_data1.itemname = ("MI CAMERA KIT");
                            temp_data1.price = 1099;
                            temp_data1.totalprice = temp_data1.quantity * 1099;
                            Console.WriteLine("");
                            Console.WriteLine("                        TOTAL PRICE: RM" + temp_data1.totalprice);
                            Console.WriteLine("");

                            temp_data1.Subtotal = temp_data1.Subtotal + (temp_data1.totalprice);
                        }
                        else
                        {
                            Console.WriteLine("                        INVALID CODE");
                        }
                        break;
                    case "C":
                        Console.WriteLine("|--------------------------------------------------------------------|");
                        Console.WriteLine();
                        Console.WriteLine("|------------------------------AUDIO---------------------------------|");
                        Console.WriteLine("|                                                                    |");
                        Console.WriteLine("|-----------------------PLEASE SELECT PRODUCT------------------------|");
                        Console.WriteLine("|                                                                    |");
                        Console.WriteLine("|          CODE             PRODUCT NAME               PRICE         |");
                        Console.WriteLine("|          3000             MI SPEAKER                 RM80          |");
                        Console.WriteLine("|          3001             MI HEADPHONES              RM185         |");
                        Console.WriteLine("|          3002             POCKET SPEAKER             RM98          |");
                        Console.WriteLine("|                                                                    |");
                        Console.WriteLine("|--------------------------------------------------------------------|");
                        Console.Write("                        PRODUCT CODE: ");
                        temp_data1.itemcode = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");

                        if (temp_data1.itemcode == 3000)
                        {
                            Console.Write("                        PLEASE ENTER QUANTITY: ");
                            temp_data1.quantity = Convert.ToInt32(Console.ReadLine());
                            temp_data1.itemname = ("MI SPEAKER");
                            temp_data1.price = 80;
                            temp_data1.totalprice = temp_data1.quantity * 80;
                            Console.WriteLine("");
                            Console.WriteLine("                        TOTAL PRICE: RM" + temp_data1.totalprice);
                            Console.WriteLine("");

                            temp_data1.Subtotal = temp_data1.Subtotal + (temp_data1.totalprice);
                        }
                        else if (temp_data1.itemcode == 3001)
                        {
                            Console.Write("                        PLEASE ENTER QUANTITY: ");
                            temp_data1.quantity = Convert.ToInt32(Console.ReadLine());
                            temp_data1.itemname = ("MI HEADPHONES");
                            temp_data1.price = 185;
                            temp_data1.totalprice = temp_data1.quantity * 185;
                            Console.WriteLine("");
                            Console.WriteLine("                        TOTAL PRICE: RM" + temp_data1.totalprice);
                            Console.WriteLine("");

                            temp_data1.Subtotal = temp_data1.Subtotal + (temp_data1.totalprice);
                        }
                        else if (temp_data1.itemcode == 3002)
                        {
                            Console.Write("                        PLEASE ENTER QUANTITY: ");
                            temp_data1.quantity = Convert.ToInt32(Console.ReadLine());
                            temp_data1.itemname = ("POCKET SPEAKER");
                            temp_data1.price = 98;
                            temp_data1.totalprice = temp_data1.quantity * 98;
                            Console.WriteLine("");
                            Console.WriteLine("                        TOTAL PRICE: RM" + temp_data1.totalprice);
                            Console.WriteLine("");

                            temp_data1.Subtotal = temp_data1.Subtotal + (temp_data1.totalprice);
                        }
                        else
                        {
                            Console.WriteLine("                        INVALID CODE");
                        }
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("               INVALID CHOICE. PLEASE ENTER CORRECT CODE!!!");
                        Console.WriteLine("|--------------------------------------------------------------------|");
                        Console.WriteLine();
                        break;
                }
                        items_data.Add(temp_data1);

                        Console.Write("                        CONTINUE SHOPPING? (Y/N): ");
                        choice = (Console.ReadLine()).ToUpper();

                        if (choice == "N")
                        break;

            } while (choice == "Y");
        }
        public void update_data()
        {
            int code;
            int newquantity;
            item temp_data = new item(); //untuk search data

            Console.WriteLine("|------------------------UPDATE ITEM QUANTITY------------------------|");
            Console.WriteLine("");
            Console.Write("                           ITEM CODE: ");
            code = Convert.ToInt32(Console.ReadLine());

            //read data 1 by 1 from arraylist then compare item code with user input
            foreach (object data in items_data)
            {
                temp_data = (item)data;

                if (temp_data.itemcode == code)
                {
                    Console.WriteLine("|--------------------------------------------------------------------|");
                    Console.WriteLine("                      ITEM DESCRIPTION: " + temp_data.itemname);
                    Console.WriteLine("                      PRICE: " + temp_data.price);
                    Console.WriteLine("                      QUANTITY: " + temp_data.quantity);
                    Console.WriteLine("|--------------------------------------------------------------------|");
                    Console.Write("                      NEW QUANTITY: ");
                    newquantity = Convert.ToInt32(Console.ReadLine());

                    temp_data.quantity = newquantity; //replace current quantity
                    temp_data.totalprice = newquantity * temp_data.price;

                    Console.WriteLine("");
                    Console.WriteLine("                      QUANTITY HAS BEEN UPDATED");
                    Console.WriteLine("|--------------------------------------------------------------------|");
                    Console.WriteLine("");
                    break;
                   
                }
                               
            }
            if(temp_data.itemcode != code)
            {
                Console.WriteLine("");
                Console.WriteLine("                      INVALID CODE!!!");
                Console.WriteLine("|--------------------------------------------------------------------|");
                Console.WriteLine("");                
            }
        }
        public void findData()
        {
            int code;
            item temp_data = new item(); //untuk search data

            Console.WriteLine("|----------------------------SEARCH ITEM-----------------------------|");            
            Console.WriteLine("");
            Console.Write("                           ITEM CODE: ");
            code = Convert.ToInt32(Console.ReadLine());

            //read data 1 by 1 from arraylist then compare item code with user input
            foreach (object data in items_data)
            {
                temp_data = (item)data;

                if (temp_data.itemcode == code)
                {
                    Console.WriteLine("|--------------------------------------------------------------------|");
                    Console.WriteLine("                      ITEM DESCRIPTION: " + temp_data.itemname);
                    Console.WriteLine("                      PRICE: " + temp_data.price);
                    Console.WriteLine("                      QUANTITY: " + temp_data.quantity);
                    Console.WriteLine("|--------------------------------------------------------------------|");
                    break;
                }
                
            }
            if (temp_data.itemcode != code)
            {
                Console.WriteLine("");
                Console.WriteLine("                           INVALID CODE!!!");
                Console.WriteLine("|--------------------------------------------------------------------|");
                Console.WriteLine("");
            }
        }

        public void Sort()
        {
            //declare new array, size = no.of arraylist data
            int[] arr_qty = new int[items_data.Count];
            item temp_data = new item();
            int i = 0;
            double subtotal = 0;
            double payment, remaining;
            string choice;

            foreach (object data in items_data)
            {
                temp_data = (item)data;
                arr_qty[i] = temp_data.itemcode;
                i++;
            }
            //call method mergesort to sort data in arr_qty
            mergesort(arr_qty, 0, arr_qty.Length - 1);

            Console.WriteLine("");
            Console.WriteLine("|---------------------------SHOPPING CART----------------------------|");
            Console.WriteLine("                                                                                          ");
            Console.WriteLine(" NO\t CODE\t DESCRIPTION\t PRICE\t QTY\t TOTAL PRICE(RM)");

            for (int j = 0; j < arr_qty.Length; j++)
            {
                foreach (object data in items_data)
                {
                    temp_data = (item)data;

                    if (arr_qty[j] == temp_data.itemcode)
                    {
                        Console.WriteLine(" {0}\t {1}\t {2}\t {3}\t {4}\t {5}", j + 1, temp_data.itemcode,
                        temp_data.itemname, temp_data.price, temp_data.quantity, temp_data.totalprice);
                        subtotal = subtotal + temp_data.totalprice;
                    }
                    
                }
                temp_data.Subtotal = subtotal;
            }
            Console.WriteLine("|--------------------------------------------------------------------|");
            Console.WriteLine("                                                 SUBTOTAL: RM" + temp_data.Subtotal);
            Console.WriteLine("");

            Console.Write("                        MAKE A PAYMENT (Y/N): ");
            choice = Console.ReadLine().ToUpper();
            if (choice == "Y")
            {
                Console.WriteLine("");
                Console.WriteLine("|---------------------------MAKE A PAYMENT---------------------------|");
                Console.WriteLine("");
                Console.WriteLine("                           SUBTOTAL: RM" + temp_data.Subtotal);
                Console.Write("                           PAYMENT: RM");
                payment = double.Parse(Console.ReadLine());

                remaining = payment - temp_data.Subtotal;

                Console.WriteLine("                           CHANGE DUE: RM" + remaining);
                Console.WriteLine("|--------------------------------------------------------------------|");
                Console.ReadKey();
            }
           
            

        }
        public void mergeArray(int[] arr, int start, int mid, int end)
        {
            /* Create a temporary array for stroing merged array (Length of temp array will be 
             * sum of size of both array to be merged)*/
            int[] temp = new int[end - start + 1];

            int i = start, j = mid + 1, k = 0;
            // Now traverse both array simultaniously and store the smallest element of both to temp array
            while (i <= mid && j <= end)
            {
                if (arr[i] < arr[j])
                {
                    temp[k] = arr[i];
                    k++;
                    i++;
                }
                else
                {
                    temp[k] = arr[j];
                    k++;
                    j++;
                }
            }
            // If there is any element remain in first array then add it to temp array
            while (i <= mid)
            {
                temp[k] = arr[i];
                k++;
                i++;
            }
            // If any element remain in second array then add it to temp array
            while (j <= end)
            {
                temp[k] = arr[j];
                k++;
                j++;
            }
            // Now temp has merged sorted element of both array

            // Traverse temp array and store element of temp array to original array
            k = 0;
            i = start;
            while (k < temp.Length && i <= end)
            {
                arr[i] = temp[k];
                i++;
                k++;
            }
        }
        // Recursive Merge Procedure
        public void mergesort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int mid = (end + start) / 2;
                mergesort(arr, start, mid);
                mergesort(arr, mid + 1, end);
                mergeArray(arr, start, mid, end);
            }
        }
        public void deleteData()
        {
            int code;
            string choice;
            item temp_data = new item(); //untuk search data

            Console.WriteLine("|----------------------------DELETE ITEM----------------------------|");
            Console.WriteLine("");
            Console.Write("                           ITEM CODE: ");
            code = Convert.ToInt32(Console.ReadLine());

            //read data 1 by 1 from arraylist then compare item code with user input
            foreach (object data in items_data)
            {
                temp_data = (item)data;

                if (temp_data.itemcode == code)
                {
                    Console.WriteLine("|--------------------------------------------------------------------|");
                    Console.WriteLine("                      ITEM DESCRIPTION: " + temp_data.itemname);
                    Console.WriteLine("                      PRICE: " + temp_data.price);
                    Console.WriteLine("                      QUANTITY: " + temp_data.quantity);
                    Console.WriteLine("|--------------------------------------------------------------------|");
                    Console.Write("                      DELETE ITEM? (Y/N): ");                    
                    choice = Console.ReadLine().ToUpper();

                    if (choice == "Y")
                    {
                        items_data.Remove(temp_data);
                        Console.WriteLine("");
                        Console.WriteLine("                      DATA HAVE BEEN REMOVED");
                        Console.WriteLine("|--------------------------------------------------------------------|");
                        Console.WriteLine("");
                        break;
                    }

                }
                
            }
            if (temp_data.itemcode != code)
            {
                Console.WriteLine("");
                Console.WriteLine("                           INVALID CODE!!!");
                Console.WriteLine("|--------------------------------------------------------------------|");
                Console.WriteLine("");
            }
        }
       
    }
   
}
