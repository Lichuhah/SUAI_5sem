import androidx.compose.desktop.DesktopMaterialTheme
import androidx.compose.desktop.ui.tooling.preview.Preview
import androidx.compose.runtime.Composable
import androidx.compose.ui.window.Window
import androidx.compose.ui.window.application
import org.suai.common.screen.LoginScreen

@Composable
@Preview
fun App() {
    LoginScreen()
}

fun main() = application {
    Window(onCloseRequest = ::exitApplication) {
        DesktopMaterialTheme() {
            App()
        }
    }
}
