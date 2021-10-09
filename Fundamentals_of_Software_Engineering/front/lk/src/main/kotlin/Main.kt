import androidx.compose.desktop.DesktopMaterialTheme
import androidx.compose.desktop.ui.tooling.preview.Preview
import androidx.compose.runtime.*
import androidx.compose.ui.window.Window
import androidx.compose.ui.window.application
import org.suai.common.model.role.studentModel
import org.suai.common.model.role.userModel
import org.suai.common.screen.LoginScreen
import org.suai.common.screen.role.StrudentScreen
import org.suai.common.utils.testData

@Composable
@Preview
fun App() {
    testData()
    val user = mutableStateOf<userModel?>(null)

    when ( user.value ) {
        null -> LoginScreen(user)
        is studentModel -> StrudentScreen(user)
    }


}

fun main() = application {
    Window(onCloseRequest = ::exitApplication) {
        DesktopMaterialTheme() {
            App()
        }
    }
}
