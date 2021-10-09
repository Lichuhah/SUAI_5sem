package org.suai.common.screen.role

import androidx.compose.foundation.layout.*
import androidx.compose.material.Text
import androidx.compose.material.TextField
import androidx.compose.runtime.*
import androidx.compose.ui.Modifier
import mu.KotlinLogging
import org.suai.common.model.role.userModel
import java.awt.Color
import javax.swing.Icon

val logger = KotlinLogging.logger{}
@Composable
fun StrudentScreen(student: MutableState<userModel?>) {
    Row {
        Box(    // Левый блок
            modifier = Modifier.fillMaxWidth(0.15f)
        ) {
            val menu = mutableListOf<pointMenuModel>()
            menu.add(
                pointMenuModel(
                    null,
                    name    = "profil",
                    color   = Color.yellow
                )
            )
            menu.add(
                pointMenuModel(
                    null,
                    name    = "books",
                    color   = Color.yellow
                )
            )
            menu.add(
                pointMenuModel(
                    null,
                    name    = "tasks",
                    color   = Color.yellow
                )
            )
            menu.add(
                pointMenuModel(
                    null,
                    name    = "settings",
                    color   = Color.yellow
                )
            )
            menuView(menu)
        }

        Box(    // Основное поле
            modifier = Modifier.fillMaxSize(1f)
        ) {
            Column {
                Row {   // Фильтры и поиск
                    var find by remember { mutableStateOf("") }
                    var entreFlag by remember { mutableStateOf(false) }
                    findString(find, entreFlag)
                    if (entreFlag) {
                        logger.info { "Push enter" }
                        entreFlag.value true
                    }
                }
                // отрисока списак задач
            }
        }
    }
}

fun findString(string: String, ef : Boolean) {
    TextField(
        value = string,
        onValueChange = { string = it }
    )
}

data class pointMenuModel(
    val icon: Icon?,
    val name: String,
    val color: Color
)

@Composable
fun menuView(
    point: MutableList<pointMenuModel>
) {
    Column {

    }
}

@Composable
fun pointView(point: pointMenuModel) {
    Text(point.name)
}