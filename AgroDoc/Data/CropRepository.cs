using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using AgroDoc.Models;

namespace AgroDoc.Data
{
    public class CropRepository
    {
        private readonly string connectionString =
            @"Server=DESKTOP-GVBF3HT\SQLEXPRESS;
              Database=AgroDocDb;
              Trusted_Connection=True;
              TrustServerCertificate=True;";

        public List<Crop> GetSuggestedCrops(
            string location,
            int duration)
        {
            List<Crop> crops = new List<Crop>();

            string query = @"
                SELECT
                    CropId,
                    CropName,
                    SuitableLocation,
                    MinDurationDays,
                    MaxDurationDays,
                    MinN,
                    MaxN,
                    MinP,
                    MaxP,
                    MinK,
                    MaxK,
                    MinPh,
                    MaxPh,
                    SuitableSoil,
                    Description
                FROM dbo.Crops
                WHERE
                    MinDurationDays <= @Duration
                    AND MaxDurationDays >= @Duration
                    AND
                    (
                        SuitableLocation LIKE '%All%'
                        OR SuitableLocation LIKE '%' + @Location + '%'
                    )
                ORDER BY CropName";

            using (SqlConnection connection =
                   new SqlConnection(connectionString))
            {
                using (SqlCommand command =
                       new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(
                        "@Duration", duration);

                    command.Parameters.AddWithValue(
                        "@Location", location);

                    connection.Open();

                    using (SqlDataReader reader =
                           command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Crop crop = new Crop();

                            crop.CropId =
                                Convert.ToInt32(reader["CropId"]);

                            crop.CropName =
                                reader["CropName"].ToString();

                            crop.SuitableLocation =
                                reader["SuitableLocation"].ToString();

                            crop.MinDurationDays =
                                Convert.ToInt32(
                                    reader["MinDurationDays"]);

                            crop.MaxDurationDays =
                                Convert.ToInt32(
                                    reader["MaxDurationDays"]);

                            crop.MinN =
                                Convert.ToDouble(reader["MinN"]);

                            crop.MaxN =
                                Convert.ToDouble(reader["MaxN"]);

                            crop.MinP =
                                Convert.ToDouble(reader["MinP"]);

                            crop.MaxP =
                                Convert.ToDouble(reader["MaxP"]);

                            crop.MinK =
                                Convert.ToDouble(reader["MinK"]);

                            crop.MaxK =
                                Convert.ToDouble(reader["MaxK"]);

                            crop.MinPh =
                                Convert.ToDouble(reader["MinPh"]);

                            crop.MaxPh =
                                Convert.ToDouble(reader["MaxPh"]);

                            crop.SuitableSoil =
                                reader["SuitableSoil"].ToString();

                            crop.Description =
                                reader["Description"].ToString();

                            crops.Add(crop);
                        }
                    }
                }
            }

            return crops;
        }
    }
}