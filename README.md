Beif
- [x] นิสิตสามารถดูข้อมูลการลงทะเบียนเรียนตนเองในเทอมก่อนหน้าได้ (1 ปีการศึกษามี 3 เทอม)
- [x] นิสิตสามารถดูข้อมูลการลงทะเบียนเรียนตนเองในเทอมปัจจุบันได้
- [x] นิสิตสามารถค้นหา และ เลือกวิชาที่จะลงทะเบียนได้นิสิตสามารถถอนรายวิชาที่ลงทะเบียนไปแล้วได้
- [x] นิสิตสามารถดูหน้า Profile ของตนเองได้
- [x] นิสิตนิสิตสามารถเข้าระบบได้ด้วย Email และ Password

RegNisit/
│── Dependencies/
│── Properties/
│── Models/                # เก็บข้อมูล Model ที่ใช้ในโปรเจกต์
│   │── AcademicYearModel.cs
│   │── CourseModel.cs
│── Pages/                 # เก็บไฟล์ XAML สำหรับ UI ของแต่ละหน้า
│   │── CourseHistoryPage.xaml
│   │── EnrollCoursePage.xaml
│   │── HomePage.xaml
│   │── LoginPage.xaml
│   │── UserProfilePage.xaml
│── Platforms/              # (MAUI-specific) โฟลเดอร์ที่เก็บโค้ดเฉพาะแพลตฟอร์ม เช่น iOS, Android
│── Resources/              # เก็บไฟล์รูปภาพ ไอคอน และสไตล์ของแอป
│── ViewModels/             # เก็บ ViewModel สำหรับการทำงานของแต่ละหน้า
│   │── CourseHistoryViewModel.cs
│   │── EnrollCourseViewModel.cs
│   │── HomePageViewModel.cs


หน้าจอสำหรับ Login 
<img width="791" alt="Screenshot 2025-03-22 at 5 03 06 PM" src="https://github.com/user-attachments/assets/e09211b7-352f-4975-b05f-0ed941905088" />

Invalid Credentials
<img width="785" alt="Screenshot 2025-03-22 at 5 03 20 PM" src="https://github.com/user-attachments/assets/904b3d12-bf11-48b9-bfa5-524d1693c615" />

Login Success
<img width="781" alt="Screenshot 2025-03-22 at 5 03 49 PM" src="https://github.com/user-attachments/assets/b5446548-79e0-4919-9e06-5f055d5d8988" />

หน้าจอแรกของ Application
  - แสดงเมนู Navbar ชื่อ RegNisit ด้านขวาเป็น Profile ของ User และมีปุ่มออกจากระบบ
  - แสดงเมนู ลงทะเบียนเรียนทั้งหมด  , ลงทะเบียนเพิ่ม ลด วิชา
  - แสดงการลงทะเบียนเรียนในเทอมปัจจุบัน
<img width="786" alt="Screenshot 2025-03-22 at 5 04 09 PM" src="https://github.com/user-attachments/assets/c063372f-0c72-4a5f-a5a3-4261de67bd6b" />

เมื่อคลิกเข้า Profile User
  - แสดงข้อมูลผู้ใช้งานในระบบ
<img width="784" alt="Screenshot 2025-03-22 at 5 04 32 PM" src="https://github.com/user-attachments/assets/a3d7774b-4dcb-46e3-ae18-4510a073a555" />

เมื่อคลิกเมนู ลงทะเบียนเรียนทั้งหมด
  - แสดงข้อมูลแต่ละปีการศึกษา และ แสดงข้อมูลแต่ละเทอม
<img width="782" alt="Screenshot 2025-03-22 at 5 05 04 PM" src="https://github.com/user-attachments/assets/e011fdd0-0c10-43c1-ae43-c3c20a2bdbcd" />
<img width="772" alt="Screenshot 2025-03-22 at 5 05 31 PM" src="https://github.com/user-attachments/assets/de83ee93-b9f5-4b79-b488-c795f6d7b573" />
<img width="784" alt="Screenshot 2025-03-22 at 5 05 37 PM" src="https://github.com/user-attachments/assets/ee0d2562-c8fc-4bd0-aa67-8d7438dece13" />
<img width="767" alt="Screenshot 2025-03-22 at 5 05 42 PM" src="https://github.com/user-attachments/assets/400e3057-0eb0-4595-938d-6aaaedc4212f" />


เมื่อคลิกเมนู ลงทะเบียนเพิ่ม ลด วิชา
  - แสดงข้อมูลวิชาที่ลงในเทอมปัจจุบันและมีปุ่มสามารถที่จะถอนรายวิชาได้
<img width="779" alt="Screenshot 2025-03-22 at 5 05 52 PM" src="https://github.com/user-attachments/assets/dc5e7ec5-39fd-4473-83fd-6f677ac61609" />
  - เมื่อถอนรายวิชาไปแล้วจะไปเพิ่มข้อมูล avaliable list ที่เก็บวิชา และ สามารถเพิ่มวิชาเข้าไปได้  
<img width="779" alt="Screenshot 2025-03-22 at 5 06 05 PM" src="https://github.com/user-attachments/assets/e4a75ff2-1354-488c-aa61-eb7f41f9c4b8" />
<img width="776" alt="Screenshot 2025-03-22 at 5 06 32 PM" src="https://github.com/user-attachments/assets/ee2f45ef-6d64-4b33-8e25-7a9a519927e2" />





