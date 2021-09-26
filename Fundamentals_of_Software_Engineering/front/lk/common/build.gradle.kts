import org.jetbrains.compose.compose

plugins {
    kotlin("multiplatform")
    id("org.jetbrains.compose") version "1.0.0-alpha3"
    id("com.android.library")
    id("kotlin-android-extensions")
}

group = "org.suai"
version = "1.0"

kotlin {
    android()
    jvm("desktop") {
        compilations.all {
            kotlinOptions.jvmTarget = "11"
        }
    }
    sourceSets {
        val commonMain by getting {
            dependencies {
                api(compose.runtime)
                api(compose.foundation)
                api(compose.material)
                implementation("io.github.microutils:kotlin-logging:2.0.3")
                implementation("org.slf4j:slf4j-api:1.7.31")
                implementation("ch.qos.logback:logback-classic:1.2.3")
                implementation("ch.qos.logback:logback-core:1.2.3")
                implementation("com.google.code.gson:gson:2.8.6")
            }
        }
        val androidMain by getting {
            dependencies {
                api("androidx.appcompat:appcompat:1.3.1")
                api("androidx.core:core-ktx:1.6.0")
                implementation("com.google.code.gson:gson:2.8.6")
            }
        }
        val desktopMain by getting {
            dependencies {
                api(compose.preview)
                implementation("io.github.microutils:kotlin-logging:2.0.3")
                implementation("org.slf4j:slf4j-api:1.7.31")
                implementation("ch.qos.logback:logback-classic:1.2.3")
                implementation("ch.qos.logback:logback-core:1.2.3")
                implementation("com.google.code.gson:gson:2.8.6")
            }
        }
    }
}

android {
    compileSdkVersion(29)
    sourceSets["main"].manifest.srcFile("src/androidMain/AndroidManifest.xml")
    defaultConfig {
        minSdkVersion(24)
        targetSdkVersion(29)
    }
    compileOptions {
        sourceCompatibility = JavaVersion.VERSION_1_8
        targetCompatibility = JavaVersion.VERSION_1_8
    }
}