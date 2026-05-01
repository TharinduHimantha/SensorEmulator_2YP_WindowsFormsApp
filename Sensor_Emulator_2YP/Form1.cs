using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using MQTTnet.Exceptions;
using Newtonsoft.Json;

namespace Sensor_Emulator_2YP
{
    public partial class Form1 : Form
    {
        private IMqttClient mqttClient;
        private IMqttClientOptions options;

        private const string BROKER = "broker.hivemq.com";
        private const int PORT = 1883;
        private const string TOPIC = "thw/telemetry/deviceA";

        public Form1()
        {
            InitializeComponent();
            InitializeMQTT();
            //btnPublish.Enabled = false;
        }

        private void InitializeMQTT()
        {
            var factory = new MqttFactory();
            mqttClient = factory.CreateMqttClient();

            mqttClient.UseConnectedHandler(e =>
            {
                Log(">MQTT connection established successfully");
                SetStatus("Connected", Color.LightGreen);
                //btnPublish.Enabled = true;
            });

            mqttClient.UseDisconnectedHandler(e =>
            {
                Log(">Disconnected from broker");
                SetStatus("Disconnected", Color.Red);
                //btnPublish.Enabled = false;
            });

            options = new MqttClientOptionsBuilder()
                .WithClientId("csharp-mqtt-publisher")
                .WithTcpServer(BROKER, PORT)
                .WithCleanSession()
                .Build();
        }


        private void Log(string message)
        {
            if (txtLogs.InvokeRequired)
            {
                txtLogs.Invoke(new Action(() =>
                {
                    txtLogs.AppendText(message + Environment.NewLine);
                }));
            }
            else
            {
                txtLogs.AppendText(message + Environment.NewLine);
            }
        }

        private void SetStatus(string text, Color color)
        {
            if (lblStatus.InvokeRequired)
            {
                lblStatus.Invoke(new Action(() =>
                {
                    lblStatus.Text = text;
                    lblStatus.ForeColor = color;
                }));
            }
            else
            {
                lblStatus.Text = text;
                lblStatus.ForeColor = color;
            }
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Log(">Trying to connect with " + BROKER + "...");
                await mqttClient.ConnectAsync(options);
            }
            catch (Exception ex)
            {
                Log("Connection failed: " + ex.Message);
            }
        }

        private async void btnPublish_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs first
                if (string.IsNullOrWhiteSpace(txtDeviceId.Text))
                {
                    Log("Error: Device ID cannot be empty.");
                    return;
                }

                if (!int.TryParse(txtDeviceId.Text, out int deviceId))
                {
                    Log($"Error: Device Id:'{txtDeviceId.Text}' must be an integer.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtValue.Text))
                {
                    Log("Error: Value cannot be empty.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSensorHealth.Text))
                {
                    Log("Error: Sensor Health cannot be empty.");
                    return;
                }

                // Parse numeric fields with proper error handling
                if (!double.TryParse(txtValue.Text, out double value))
                {
                    Log($"Error: Sensor Reading '{txtValue.Text}' is not a valid number.");
                    return;
                }

                if (!int.TryParse(txtSensorHealth.Text, out int sensorHealth))
                {
                    Log($"Error: Sensor Health '{txtSensorHealth.Text}' is not a valid integer.");
                    return;
                }

                if ((sensorHealth < 0) || (sensorHealth > 100)){
                    Log("Error: Sensor Health must be an Integer of 0 - 100");
                    return;
                } 

                var payloadObj = new
                {
                    deviceId = deviceId,
                    value = value,
                    sensorHealth = sensorHealth,
                    timestamp = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ")
                };

                string json = JsonConvert.SerializeObject(payloadObj);

                var message = new MqttApplicationMessageBuilder()
                    .WithTopic(TOPIC)
                    .WithPayload(json)
                    .WithQualityOfServiceLevel(MQTTnet.Protocol.MqttQualityOfServiceLevel.AtLeastOnce)
                    .Build();

                if (mqttClient.IsConnected)
                {
                    await mqttClient.PublishAsync(message);
                    Log(">Publish confirmed (QoS 1)");
                    Log(">Message sent: " + json);
                }
                else
                {
                    Log("Error: MQTT client not connected. Message not sent.");
                }
            }
            catch (JsonException jsonEx)
            {
                Log("JSON Serialization Error: " + jsonEx.Message);
            }
            catch (MqttCommunicationException mqttEx)
            {
                Log("MQTT Communication Error: " + mqttEx.Message);
            }
            catch (Exception ex)
            {
                Log("Unexpected Error: " + ex.Message);
            }
        }


    }
}
