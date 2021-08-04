using GD.NP.Framework.FastDFS.Client;
using GD.NP.Framework.Security;
namespace ConsoleApp1
{

    public class RsaDa
    {
        // 私钥
        string priKey = "MIICdQIBADANBgkqhkiG9w0BAQEFAASCAl8wggJbAgEAAoGBAL4IOwjgnig/Sea7HPRNEVR+qHC92aw2XD2vGQcnJIy/oPyME2VQEzqAawO/wzUUlAUC7HyrYDkg6CrGXqebfnqsuaAdG0/Ri2K2RIp0adT4l2vIJliDhTPpRFKspUp46xuKqKEMe3uNKh38M8BAQiSnezVaJJ1gh3A/SWiLtdCjAgMBAAECgYBF+HvcOfCiOyN37J+tqI7gAL7+vDjg+ycdo1Jg2t3PYWPieaVOoZxi5xQATmSPL+OMsNXo1aVZg69YyK/joRKBcGbIbL2nfh2y/mGE+7BQbZGyS/LR5aO+LudRShMrtbnsb+Xa+H1rxE4Ib+IFfBa7hQCPFtS3MN8IeUKw13Li6QJBAOefI0RChN6rBnOMnzj8g8Clfdf81rNMVk1X5HBhOfe/6awawXbv8mU/vp8zD9fK1dx2vEfHxTF1UVRH+OlmvbUCQQDSCH8/67Spg8mE9vZ/FieJt06OTkHpdB4SWAXJupPEkfBcteFiTPOz3lAmtnoXDVdN2AgolxCrVuTKGylGdgv3AkAH8s0aBZJbtdDF3FiGcxvuW3+DDvkrM/5uLwr21E9R8jMJpe1nsHpIATUAb5cml55ZL3XsnK1mshj1ZHblQ5JVAkBaLhHM9TxVyGL/NzZxLKb/R3hwO4OrZBMBV0/s5LJLpUmp1OIX3eiJYzvQ02qqeSzyHH6sRuh+WMnVSUI4objTAkBHzsxYZyq4BUS1jhtz1De4zaaSYpmK6OpPa5tO8J8kAFdBs1SEXWC90YuUeR0nqk1SQ4eKcX7AmwXDvyP6WTaI";
        // 公钥
        string pubKey = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQC+CDsI4J4oP0nmuxz0TRFUfqhwvdmsNlw9rxkHJySMv6D8jBNlUBM6gGsDv8M1FJQFAux8q2A5IOgqxl6nm356rLmgHRtP0YtitkSKdGnU+JdryCZYg4Uz6URSrKVKeOsbiqihDHt7jSod/DPAQEIkp3s1WiSdYIdwP0loi7XQowIDAQAB";

        // 错误信息
        string errMsg = "";
        // 明文，待加密对象
        string content = "Aa汉字1@# 23";

        public void DDD()
        {
            // 调用方式
            var mm = GdRsa.EncryptData(content, pubKey, ref errMsg);

            // 利用私钥解密
            // resData: 需要解密的数据
            // privateKey: 私钥
            // errMsg:错误信息
            // 调用方式
            var jm = GdRsa.DecryptData(mm, priKey, ref errMsg);


        }

    }
}
