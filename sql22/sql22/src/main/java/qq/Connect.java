package qq;

import java.sql.*;

public class Connect {
    private static Connection conn = null;
    public Connect() {
        try {
            String dbURL = "jdbc:postgresql://localhost:5334/ychet_autostoyanki";
            String user = "postgres";
            String pass = "6519";
            conn = DriverManager.getConnection(dbURL, user, pass);
        } catch (SQLException ex) {
            ex.printStackTrace();
        }
    }


    public ResultSet Select(String operation) throws SQLException {
        Statement st = conn.createStatement();
        String sql = operation;
        ResultSet set = st.executeQuery(sql);
        return set;
    }

    public void InsertnUpdate(String operation) throws SQLException {
        Statement st = conn.createStatement();
        String sql = operation;
        st.executeUpdate(sql);
    }
}
