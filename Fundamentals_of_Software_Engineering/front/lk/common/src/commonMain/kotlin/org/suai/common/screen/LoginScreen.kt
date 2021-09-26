package org.suai.common.screen

import androidx.compose.foundation.layout.*
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.material.Button
import androidx.compose.material.OutlinedTextField
import androidx.compose.material.Text
import androidx.compose.runtime.*
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.text.style.TextAlign
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp

@Composable
fun LoginScreen() {
    var login          by remember { mutableStateOf("") }
    var password       by remember { mutableStateOf("") }
    var secondPassword by remember { mutableStateOf("") }
    var firstName      by remember { mutableStateOf("") }
    var secondName     by remember { mutableStateOf("") }
    var otherName      by remember { mutableStateOf("") }

    var registerButtonText by remember { mutableStateOf("v") }
    var buttonText     by remember { mutableStateOf("Вход") }
    var errorText      by remember { mutableStateOf("") }

    var registerOn     by remember { mutableStateOf(false) }
    var buttonTap      by remember { mutableStateOf(false) }

    LazyColumn (
        modifier            = Modifier.fillMaxSize(),
        verticalArrangement = Arrangement.Center,
        horizontalAlignment = Alignment.CenterHorizontally
    ){
        if ( errorText.isNotEmpty() )
            item {
                Text(
                    text     = errorText,
                    fontSize = 16.sp
                )
            }
        item {
            Text(
                text     = "Личный кабинет ГУАП",
                fontSize = 26.sp
            )
        }
        item {
            OutlinedTextField(
                value         = login,
                onValueChange = { login = it },
                label         = { Text("Логин") }
            )
            OutlinedTextField(
                value         = password,
                onValueChange = { password = it },
                label         = { Text("Пароль") }
            )
        }
        item {
            Box (
                Modifier.padding(top = 3.dp)
            ) {
                Button (
                    onClick = {
                        registerOn = !registerOn
                        if ( registerOn ) {
                            buttonText = "Регистрация"
                        }
                        else {
                            buttonText = "Вход"
                        }
                    },
                    content = {
                        Box {
                            Text(registerButtonText,
                                fontSize = 10.sp)
                        }
                    }
                )
            }
        }
        if ( registerOn )
            item {
                Box( modifier = Modifier.fillMaxWidth(0.25f)) {
                    Text(
                        text     = "Регистрация",
                        fontSize = 16.sp,
                        textAlign = TextAlign.Start
                    )
                }
                OutlinedTextField(
                    value         = firstName,
                    onValueChange = { firstName = it },
                    label         = { Text("Имя") }
                )
                OutlinedTextField(
                    value         = secondName,
                    onValueChange = { secondName = it },
                    label         = { Text("Фамилия") }
                )
                OutlinedTextField(
                    value         = otherName,
                    onValueChange = { otherName = it },
                    label         = { Text("Отчество") }
                )
                OutlinedTextField(
                    value         = secondPassword,
                    onValueChange = { secondPassword = it },
                    label         = { Text("Повторите ввод пароля") }
                )
            }
        item {
            Box (
                Modifier.padding(top = 3.dp)
            ) {
                Button(
                    onClick = { buttonTap = !buttonTap },
                    content = { Text(buttonText) }
                )
            }
        }
    }
}