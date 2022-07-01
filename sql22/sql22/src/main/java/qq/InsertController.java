package qq;

import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.fxml.FXML;
import javafx.scene.control.*;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

import static java.sql.DriverManager.getConnection;

public class InsertController implements EventHandler<ActionEvent> {
    @FXML
    private Label label;
    private ObservableList<Database> clientusers = FXCollections.observableArrayList();

    @FXML
    private TextField licensevehicle;
    @FXML
    private DatePicker checkintime;
    @FXML
    private DatePicker checkouttime;
    @FXML
    private TextField numberphone;
    @FXML
    private TextField lastname;

    @FXML
    private TextField firstname;

    @FXML
    private TextField midname;

    @FXML
    private TextField serianumber;

    @FXML
    private TextField price;

    @FXML
    private ComboBox carname;
    @FXML
    private ComboBox autostops;
    @FXML
    private Button button;

    public Connect bd;

    @FXML
    public void initialize() throws SQLException {
        bd = new Connect();
        List<String> type = new ArrayList<>();
        ResultSet resultSet = bd.Select("select \"Autoname\" from \"Autos\"");
        while (resultSet.next()){
            type.add(resultSet.getString("Autoname"));
        }
        List<String> newAuto = type.stream().distinct().collect(Collectors.toList());

        carname.setItems(FXCollections.observableArrayList(newAuto));

        List<String> stops = new ArrayList<>();
        ResultSet rs = bd.Select("select \"Name\" from \"Autostops\"");
        while (rs.next()){
            stops.add(resultSet.getString("Name"));
        }
        List<String> newStops = type.stream().distinct().collect(Collectors.toList());

        autostops.setItems(FXCollections.observableArrayList(newStops));
        button.setOnAction(this);
    }

    @Override
    public void handle(ActionEvent actionEvent) {
        if (actionEvent.getSource() == button) {
            clientusers.clear();
            String type = (String) carname.getValue();
            String lastnameText = (String) lastname.getText();
            String firstnametxt = firstname.getText();
            String midnametxt = midname.getText();
            String seria = serianumber.getText();
            String licen = licensevehicle.getText();
            String nphone = numberphone.getText();
            String priceee = price.getText();
            String stops = (String) autostops.getValue();
            LocalDate checkin = checkintime.getValue();
            LocalDate checkout = checkouttime.getValue();

            try {
                ResultSet rs = bd.Select((
                        "select \"Autoname\" , \"Gosnumber\", \"Indate\", " +
                                "\"Outdate\", \"Numberphone\", \"Lastname\", \"Summ\" " +
                                "from \"Vouchers\" as V " +
                                "inner join \"Contracts\" C on V.\"Id\" = C.\"VouchersId\"" +
                                "inner join \"Clients\" cl on C.\"ClientsId\" = cl.\"Id\""+
                                "inner join \"Autos\" A on cl.\"AutosId\" = A.\"Id\" " +
                                "group by \"Autoname\", \"Gosnumber\", \"Lastname\", \"Indate\", \"Outdate\"," +
                                "\"Numberphone\", \"Lastname\", \"Summ\""));
                while (rs.next()) {
                    clientusers.add(new Database("go",
                            rs.getString("Autoname"),
                            rs.getString("Gosnumber"),
                            rs.getDate("Indate"),
                            rs.getDate("Outdate"),
                            rs.getString("Numberphone"),
                            rs.getString("Lastname"),
                            rs.getInt("Summ")
                    ));
                }
                int id_auto = 0;
                int id_vo = 0;
                int id_co = 0;
                int id_author_cl = 0;
                int id_cliet = 0;
                int id_sto = 0;
                ResultSet au = bd.Select("select \"Id\" from \"Autos\" where \"Autoname\"='"+type+"'");
                if (au.next()){
                    id_auto = au.getInt(1);
                }
                ResultSet vo = bd.Select("select max(\"Id\") from \"Vouchers\"");
                if (vo.next()){
                    id_vo = vo.getInt(1) + 1;
                }
                ResultSet co = bd.Select("select max(\"Id\") from \"Contracts\"");
                if (co.next()){
                    id_co = co.getInt(1) + 1;
                }
                ResultSet author = bd.Select("select max(\"Id\") from \"Authorizations\"");
                if (author.next()){
                    id_author_cl = author.getInt(1) + 1;
                }
                ResultSet client = bd.Select("select max(\"Id\") from \"Clients\"");
                if (client.next()){
                    id_cliet = client.getInt(1) + 1;
                }
                ResultSet sto = bd.Select("select \"Id\" from \"Autostops\" where \"Name\"='"+stops+"'");
                if (sto.next()){
                    id_sto = sto.getInt(1);
                }
                int id = clientusers.size() + 1;
                if (lastnameText.isEmpty()==false){
                    bd.InsertnUpdate("insert into \"Authorizations\" values ("+id_author_cl+","+
                            "'client_"+id_author_cl+"','" +seria+"')");

                    bd.InsertnUpdate("insert into \"Clients\" " +
                            "values("+id_cliet+",'"+ lastnameText+"','"+firstnametxt + "','"+ midnametxt+
                            "','"+licen + "','"+id_auto + "','" + nphone+"','"
                            +seria+ "','"+3+"')");

                    bd.InsertnUpdate("insert into \"Vouchers\" values ("+id_vo+
                            ",'"+checkintime.getValue().toString()+"','"+ checkouttime.getValue().toString()+"',"+
                            priceee+","+1+")");
                    int id_author = Authorization.id_authorization;
                    bd.InsertnUpdate("insert into \"Contracts\" values ("+id_co+",'"+
                            checkouttime.getValue().toString()+"',"
                            +id_sto+","+id_author+","+id_vo+","+id_cliet+")");

                    label.setText("Добавлено");
                }
            } catch (SQLException e) {
                e.printStackTrace();
            }
        }
    }
}
