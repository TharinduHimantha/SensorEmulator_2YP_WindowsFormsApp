# Sensor Emulator (MQTT Publisher - WinForms)

A simple Windows Forms application that simulates an IoT sensor by publishing telemetry data to an MQTT broker.
This tool allows manual input of sensor values and sends structured JSON messages using QoS 1.

---

## 🚀 Features

* Connect to a public MQTT broker
* Publish sensor data in JSON format
* QoS 1 message delivery (reliable publish)
* Real-time log output
* User-friendly UI for input
* Automatic UTC timestamp generation
* Connection status handling
* Prevents publishing when disconnected

---

## 🧱 Tech Stack

* **C# (.NET Framework 4.7.2)**
* **Windows Forms**
* **MQTTnet (v3.1.2)**
* **Newtonsoft.Json**

---

## 📡 MQTT Configuration

| Parameter | Value                   |
| --------- | ----------------------- |
| Broker    | `broker.hivemq.com`     |
| Port      | `1883`                  |
| Topic     | `thw/telemetry/deviceA` |
| QoS       | `1 (AtLeastOnce)`       |

---

## 📦 Message Format

The application publishes data in the following JSON structure:

```json
{
  "deviceId": "5464",
  "value": 65.12,
  "sensorHealth": 49,
  "timestamp": "2026-04-17T23:22:07Z"
}
```

* `deviceId` → Unique identifier of the device
* `value` → Sensor reading
* `sensorHealth` → Health indicator (0–100)
* `timestamp` → Auto-generated (UTC)

---

## 🖥️ UI Overview

The application is divided into three main sections:

### 🔹 Connection

* Connect to MQTT broker
* Displays connection status

### 🔹 Payload

* Input fields:

  * Device ID
  * Value
  * Sensor Health
* Publish button (enabled only when connected)

### 🔹 Logs

* Displays connection events and publish confirmations

---

## ▶️ How to Run

Extract the content in `SensorEmulator_2YP_WindowsFormsApp.zip` and run the program in any Windows machine.

* **The program can be only run in a desktop machine with a Windows operating system**

<img width="595" height="448" alt="image" src="https://github.com/user-attachments/assets/79fd53a1-e8fb-477b-82eb-6c9844bfff36" />


---

## 🧪 Usage

1. Click **Connect**
2. Enter sensor values:

   * Device ID
   * Value
   * Sensor Health
3. Click **Publish**
4. Check logs for confirmation

---

## ⚠️ Notes

* Ensure you are connected before publishing
* Uses a public broker (no authentication required)
* Messages are sent in UTF-8 encoded JSON
* QoS 1 ensures delivery but may result in duplicate messages

---

