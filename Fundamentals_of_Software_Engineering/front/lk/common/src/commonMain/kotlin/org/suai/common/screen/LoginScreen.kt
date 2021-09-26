package org.suai.common.screen

import androidx.compose.foundation.layout.*
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.material.Button
import androidx.compose.material.OutlinedTextField
import androidx.compose.material.Text
import androidx.compose.runtime.*
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.text.input.PasswordVisualTransformation
import androidx.compose.ui.text.input.VisualTransformation
import androidx.compose.ui.text.style.TextAlign
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import mu.KLogger
import mu.KotlinLogging
import mu.toKLogger
import org.suai.common.LoginManager
import org.suai.common.Role
import org.suai.common.model.loginModel

@Composable
fun LoginScreen() {
    KotlinLogging.logger{}.info { "recompose LoginScreen" }

    var login              by remember { mutableStateOf("") }
    var password           by remember { mutableStateOf("") }
    var second_password    by remember { mutableStateOf("") }
    var first_name          by remember { mutableStateOf("") }
    var second_name        by remember { mutableStateOf("") }
    var other_name         by remember { mutableStateOf("") }

    var registerButtonText by remember { mutableStateOf("v") }
    var buttonText         by remember { mutableStateOf("Вход") }
    var errorText          by remember { mutableStateOf("") }

    var registerOn         by remember { mutableStateOf(false) }

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
                label         = { Text("Пароль") },
                visualTransformation = PasswordVisualTransformation(),
                )
        }
        item {
            Box (
                Modifier.padding(top = 3.dp)
            ) {
                Button(
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
                    value         = first_name,
                    onValueChange = { first_name = it },
                    label         = { Text("Имя") }
                )
                OutlinedTextField(
                    value         = second_name,
                    onValueChange = { second_name = it },
                    label         = { Text("Фамилия") }
                )
                OutlinedTextField(
                    value         = other_name,
                    onValueChange = { other_name = it },
                    label         = { Text("Отчество") }
                )
                OutlinedTextField(
                    value         = second_password,
                    onValueChange = { second_password = it },
                    label         = { Text("Повторите ввод пароля") },
                    visualTransformation = PasswordVisualTransformation(),
                )
            }
        item {
            Box (
                Modifier.padding(top = 3.dp)
            ) {
                Button(
                    onClick = {
                        if ( registerOn ){
                            KotlinLogging.logger {}.info { "register login=$login pas=$password first_name=$first_name second_name=$second_name other_name=$other_name" }
                            val response = LoginManager.sendToServer( loginModel(login, password) )
                            when ( response.role ) {
                                Role.NONE -> {
                                    KotlinLogging.logger{}.info { "login" }
                                    errorText = response.message
                                }
                                    else  -> KotlinLogging.logger{}.info { "login" }
                            }
                        } else {
                            KotlinLogging.logger {}.info { "login login=$login pas=$password" }

                        }
                    },
                    content = { Text(buttonText) }
                )
            }
        }
    }
}