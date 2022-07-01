package qq;

import java.sql.Date;
import java.time.LocalDate;

public class ToClass {
    static Integer Selecter=null;
    static String Autotitle=null;
    static String Gosnumber=null;
    static LocalDate inDate=null;
    static LocalDate outDate=null;
    static String N_phone=null;
    static String Clientname=null;
    static Integer Bigsumm=null;

    public static String getAutotitle() {
        return Autotitle;
    }

    public static void setAutotitle(String autotitle) {
        Autotitle = autotitle;
    }

    public static String getGosnumber() {
        return Gosnumber;
    }

    public static void setGosnumber(String gosnumber) {
        Gosnumber = gosnumber;
    }

    public static LocalDate getInDate() {
        return inDate;
    }

    public static void setInDate(Date inDate) {
        inDate = inDate;
    }

    public static LocalDate getOutDate() {
        return outDate;
    }

    public static void setOutDate(Date outDate) {
        outDate = outDate;
    }

    public static String getN_phone() {
        return N_phone;
    }

    public static void setN_phone(String n_phone) {
        N_phone = n_phone;
    }

    public static String getClientname() {
        return Clientname;
    }

    public static void setClientname(String clientname) {
        Clientname = clientname;
    }

    public static Integer getBigsumm() {
        return Bigsumm;
    }

    public static void setBigsumm(Integer bigsumm) {
        Bigsumm = bigsumm;
    }

    public static void SetSelecter(Integer selecterint){
        Selecter=selecterint;
    }
    public static Integer GetSelecter(){
        return Selecter;
    }

}
