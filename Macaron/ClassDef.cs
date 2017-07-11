using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace csWinForm {
    class ClassDef {

    }

    class Management {///
        private List<Car> car_list;
        private List<Member> member_list;
        private List<Reservation> total_resv_list;
        // like temporary variables from DBMS

        public int Add_car(Car car) { return 0; }   // 차량 추가
        public int Remove_car(Car car) { return 0; }    // 차량 제거
        public int Add_resv(Reservation resv) { return 0; } // 대여
        public int Return_car(Reservation resv) { return 0; }   // 반납
        public int Req_repair(Car car) { return 0; }    // 정비차량 입고
        public int Get_repaired(Car car) { return 0; }  // 정비차량 출고
        public int Update_fix(Car car, Supplies supplies) { return 0; }    // 경정비 업데이트
        public void Inquire_car() { } // 추가: 차량 조회

        public void Update_info() { }   // 반납 등의 프로세스 수행 후 차량 상태 업데이트
        public void Check_supplies() { }    // 정비 도래항목 확인
        /*
        management에서 DB에 반영하고 남은 임시 데이터를
        Car와, Reservation, Member에 넣는 게 더 효율적일까
        */

    }
    /// <summary>
    /// Singleton DB Controller
    /// </summary>
    class DBManager {
        private static DBManager instance;
        private static MySqlConnection con;

        private DBManager() {
            string cs = @"server=edu.khuhacker.com;userid=macaron;password=A+Please;database=macaron;charset=utf8";
            con = new MySqlConnection(cs);
            con.Open();
        }
        public static DBManager Instance {
            get {
                instance = instance ?? new DBManager();
                return instance;
            }
        }
    }



    

    class Member {
        public string Member_name { get; set; }
        public string Member_id { get; set; }   // PK
        public string Phone_number { get; set; }

    }

    class Car {
        public string Car_name { get; set; }
        public string Car_number { get; set; }
        public int ODOmeter { get; set; }
        public bool Pitin { get; set; }     // 정비상태
    }

    enum CarState {

    }

    class Reservation {
        // DBMS에서 가져오는 부분은 update에서 이루어지므로 생성자만 set가능
        public int Resv_index { get; set; }
        public string Car_number { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }
        public string Member_id { get; set; }


        public Reservation(int index, string number, DateTime start, DateTime end, string id) { }

    }

    class Supplies {
        // DBMS에서 가져오는 부분은 update에서 이루어지므로 생성자만 set가능
        public string Type { get; internal set; }
        public DateTime Changed_date { get; internal set; }
        public int Changed_ODO { get; internal set; }

        public Supplies(string type, DateTime date, int ODO) { }

    }
}
