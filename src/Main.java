import java.io.IOException;

public class Main {

	public static void main(String[] args) {
		try {
			Runtime rt = Runtime.getRuntime();
			rt.exec("WebBrowser/WebBrowser/bin/Debug/WebBrowser.exe");
		} catch (IOException ex) {
			ex.printStackTrace();
		}
	}

}