package qq;

import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.*;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.stage.Modality;
import javafx.stage.Stage;

import java.io.IOException;
import java.sql.*;
import java.time.LocalDateTime;
import java.time.ZonedDateTime;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.List;
import java.util.stream.Collectors;

import static qq.ToClass.*;

public class HelloController implements EventHandler<ActionEvent> {
    @FXML
    private Label label;
    private ObservableList<Database> clientusers = FXCollections.observableArrayList();
    @FXML
    private TableView<Database> tableView;

//    @FXML
//    private TableColumn<Database,Integer> id_role;

    @FXML
    private TableColumn<Database,String> status;
    @FXML
    private TableColumn<Database,String> carname;
    @FXML
    private TableColumn<Database,String> licensevehicle;
    @FXML
    private TableColumn<Database, Time> checkintime;
    @FXML
    private TableColumn<Database, Time> checkouttime;
    @FXML
    private TableColumn<Database,Integer> numberphone;
    @FXML
    private TableColumn<Database,String> lastname;
    @FXML
    private TableColumn<Database, Integer> price;

    @FXML
    private Button refresh;
    @FXML
    private Button add;
    @FXML
    private Button updatebut;
    @FXML
    private Button search;
    @FXML
    private ComboBox forsearch;
    @FXML
    private TextField Summsearch;
    @FXML
    private CheckBox filterOn;

    public Connect bd;

    @FXML
    public void  initialize () throws SQLException {
        add.setOnAction(actionEvent -> {
            openfxml("insertB.fxml");
        });
        updatebut.setOnAction(actionEvent -> {

        });

        tableView.setOnMouseClicked(mouseEvent -> {
            TableView.TableViewSelectionModel<Database> temp = tableView.getSelectionModel();
            String id_search = "";
            try {
                ResultSet resultSet = bd.Select("select \"Id\" from \"Clients\" where \"Numberphone\"=" + temp.getSelectedItem().getNumberphone() +
                        " and \"Gosnumber\"='" + temp.getSelectedItem().getLicensevehicle() + "' limit 1");
                while (resultSet.next()){
                    id_search = resultSet.getString(1);
                }
            } catch (SQLException e) {
                e.printStackTrace();
            }
            SetSelecter(Integer.valueOf(id_search));
            setAutotitle(temp.getSelectedItem().getCarname());
            setGosnumber(temp.getSelectedItem().getLicensevehicle());
            setInDate(temp.getSelectedItem().getCheckintime());
            setOutDate(temp.getSelectedItem().getCheckouttime());
            setN_phone(temp.getSelectedItem().getNumberphone());
            setClientname(temp.getSelectedItem().getLastname());
            setBigsumm(temp.getSelectedItem().getPrice());
            openfxml("update.fxml");
        });
        bd = new Connect();
        List<String> model_type_sample = new ArrayList<>();
        ResultSet resultSet = bd.Select("select \"Autoname\" from \"Autos\"");
        while (resultSet.next())
        {
            model_type_sample.add(resultSet.getString("Autoname"));
        }
        List<String> newModels = model_type_sample.stream().distinct().collect(Collectors.toList());
        forsearch.setItems(FXCollections.observableArrayList(newModels));
        search.setOnAction(this);
        refresh.setOnAction(this);
        filterOn.setOnAction(this);
        Summsearch.setText("0");


        status.setCellValueFactory(new PropertyValueFactory<Database, String>("status"));
        carname.setCellValueFactory(new PropertyValueFactory<Database, String>("carname"));
        licensevehicle.setCellValueFactory(new PropertyValueFactory<Database, String>("licensevehicle"));
        checkintime.setCellValueFactory(new PropertyValueFactory<Database, Time>("checkintime"));
        checkouttime.setCellValueFactory(new PropertyValueFactory<Database, Time>("checkouttime"));
        numberphone.setCellValueFactory(new PropertyValueFactory<Database, Integer>("Numberphone"));
        lastname.setCellValueFactory(new PropertyValueFactory<Database, String>("Lastname"));
        price.setCellValueFactory(new PropertyValueFactory<Database, Integer>("price"));
    }

    @Override
    public void handle(ActionEvent actionEvent) {
        clientusers.clear();
        String type = (String) forsearch.getValue();
        String sumsearch = Summsearch.getText();
        if (filterOn.isSelected() && actionEvent.getSource() == search){
            zapolnenieTable(" where \"Autoname\"='"+type + "' and " +"\"Summ\"="+sumsearch);
        }
        if (filterOn.isSelected()==false && actionEvent.getSource() == search){
            zapolnenieTable(" where \"Autoname\"='"+type + "' or \"Summ\"="+sumsearch);
        }
        if(actionEvent.getSource()==refresh){
            zapolnenieTable("group by \"Autoname\", \"Gosnumber\"," +
                    "\"Indate\",\"Outdate\", \"Numberphone\", \"Lastname\", \"Summ\"");

            List<String> model_type_sample = new ArrayList<>();
            ResultSet resultSet = null;
            try {
                resultSet = bd.Select("select \"Autoname\" from \"Clients\" as cl " +
                        "inner join \"Autos\" A on A.\"Id\" = cl.\"AutosId\"");
                while (resultSet.next())
                {
                    model_type_sample.add(resultSet.getString("Autoname"));
                }
                List<String> newModels = model_type_sample.stream().distinct().collect(Collectors.toList());
                forsearch.setItems(FXCollections.observableArrayList(newModels));
            } catch (SQLException e) {
                e.printStackTrace();
            }

        }
    }

    private void openfxml(String ffxml){
        FXMLLoader loader = new FXMLLoader();
        loader.setLocation(getClass().getResource(ffxml));
        try {
            loader.load();
        } catch (IOException e) {
            e.printStackTrace();
        }
        Parent root= loader.getRoot();
        Stage stage = new Stage();
        stage.initModality(Modality.APPLICATION_MODAL);
        stage.setScene(new Scene(root));
        stage.showAndWait();
    }

    private void zapolnenieTable(String select){
        String rq_refresh = "select \"Autoname\" , \"Gosnumber\", \"Indate\", " +
                "\"Outdate\", \"Numberphone\", \"Lastname\", \"Summ\" " +
                "from \"Vouchers\" as V " +
                "inner join \"Contracts\" C on V.\"Id\" = C.\"VouchersId\"" +
                "inner join \"Clients\" cl on C.\"ClientsId\" = cl.\"Id\""+
                "inner join \"Autos\" A on cl.\"AutosId\" = A.\"Id\"";
        try {
            String rq = rq_refresh + select;
            ResultSet rs  = bd.Select((rq));
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
                clientusers.stream().distinct().collect(Collectors.toList());
                tableView.setItems(clientusers);
            }
        } catch (SQLException exception) {
            exception.printStackTrace();
        }
    }
}