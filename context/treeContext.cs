using forex.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace forex.context
{
    public class treeContext
    {
        public treelist treeSee(string uid, string connectionString)
        {
            treelist tl = new treelist();
            List<treeModel> noListO = new List<treeModel>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("proranksdata", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                con.Open();
                cmd.Parameters.AddWithValue("@userid", uid);
                cmd.Parameters.AddWithValue("@action", "show");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                tl.name = ds.Tables[1].Rows[0]["name"].ToString();
                tl.mobile = ds.Tables[1].Rows[0]["mobile"].ToString();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    treeModel srq = new treeModel();
                    srq.RankName = ds.Tables[0].Rows[i]["RankName"].ToString();
                    srq.Rank = ds.Tables[0].Rows[i]["Ranks"].ToString();
                    srq.c1 = ds.Tables[0].Rows[i]["c1"].ToString();
                    srq.c2 = ds.Tables[0].Rows[i]["c2"].ToString();
                    srq.c3 = ds.Tables[0].Rows[i]["c3"].ToString();
                    noListO.Add(srq);
                }
                con.Close();
            }
            tl.treelistobj = noListO;
            return tl;
        }


        public treelist LevelSee(string uid, string connectionString)
        {
            treelist tl = new treelist();

            List<treeModel> noListO = new List<treeModel>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("prolevelupgradenew", con)
                {
                    CommandType = CommandType.StoredProcedure

                };
                con.Open();
                cmd.Parameters.AddWithValue("@userid", uid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);              
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    treeModel srq = new treeModel();                   
                    noListO.Add(srq);
                }
                con.Close();
            }
            tl.treelistobj = noListO;
            return tl;
        }

        
    }
    public class TreeDataaccess
        {
            public TreeView GetAlltree(string connectionString, string uid, string sid, string status)
            {
                string im ="/../image/Empty.png";            
                TreeView Trees = new TreeView();
                var IncomeList = new List<Income>();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string[] N = new string[18];
                    SqlCommand cmd = new SqlCommand("prosnodecheck", con)
                    {
                        CommandType = CommandType.StoredProcedure

                    };
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;
                    cmd.Parameters.AddWithValue("@parentid", sid);
                    cmd.Parameters.AddWithValue("@checkid", uid);
                    SqlDataAdapter dataAdapter2 = new SqlDataAdapter(cmd);
                    DataSet dataSet2 = new DataSet();
                    dataAdapter2.Fill(dataSet2);
                    if (dataSet2.Tables[0].Rows[0][0].ToString() == "0" && sid != uid)
                    {
                        Trees.span1 = "<center>Not Associates with this id !.</center>";
                        con.Close();
                        return Trees;

                    }

                    SqlCommand cmd2 = new SqlCommand("[lbinaryplanB]", con);
                    // SqlCommand cmd = new SqlCommand("pro_selete_nodetable", con);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.CommandTimeout = 0;
                    cmd2.Parameters.AddWithValue("@referid", uid);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd2);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);
                    //dataSet.Tables[0].Rows[0]["ranks"].ToString();
                    con.Close();
                    string a = uid;
                    string b = "%L%";
                    string c = "%R%";

                    DataRow[] result = dataSet.Tables[0].Select(string.Format("tnode_id='{0}'", a));
                    if ((result.Count()) == 0 || result == null)
                    {

                        Trees.span1 = "<img src=\"" + im + "\"> ";
                        Trees.span1id = "Create ID";
                    }
                    foreach (DataRow row in result)
                    {
                        N[0] = row["tnode_id"].ToString();
                        //lbl1.Text = "Left Child : " + row["ttleftchild"].ToString();
                        //lbl2.Text = "Left Child : " + row["ttleftpv"].ToString();
                        //lbl3.Text = "Star Magic Left : " + row["ttspill_c"].ToString();
                        //lbl4.Text = "Right Child : " + row["ttrightchild"].ToString();
                        //lbl5.Text = "Right Child : " + row["ttrightpv"].ToString();
                        //lbl6.Text = "Star Magic Right : " + row["ttspill_d"].ToString();

                        //string data = "<table><tr><td class='success'> Name </td> <td>  " + row["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row["tsponsor_id"].ToString() + "-" + row["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row["ttleftpv"].ToString() + "<br>RIGHT : " + row["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row["ttleftchild"].ToString() + "<br>Right : " + row["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $   " + row["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row["tnodename"].ToString() + "</td></tr><tr><td> $   " + row["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row["ttleftpv"].ToString() + ", RIGHT : " + row["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row["ttleftchild"].ToString() + ", Right : " + row["ttrightchild"].ToString() + "</table>";
                        Trees.span1 = "<img src=\"" + img(row["ranks"].ToString()) + "\"> ";
                        Trees.span1id = row["tnode_id"].ToString();
                        Trees.data1id = data;
                        Trees.name1id = row["tnodename"].ToString();
                }

                    DataRow[] result1 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[0], b));
                    if ((result1.Count()) == 0 || result1 == null)
                    {

                        Trees.span2 = "<img src=\"" + im + "\"> ";
                        Trees.span2id = "Empty";
                        try
                        {
                            if (N[0].ToString().Length > 4)
                            {
                                Trees.span2 = "<img src=\"" + im + "\"> ";
                                Trees.span2id = "<a style=\"color:blue !important;\" href=\"register?id=" + N[0].ToString() + "&L=L\"> Create ID </a>";
                            }
                        }
                        catch
                        {

                        }

                    }
                    foreach (DataRow row1 in result1)
                    {
                        N[1] = row1["tnode_id"].ToString();
                        //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row1["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row1["tsponsor_id"].ToString() + "-" + row1["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row1["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row1["ttleftpv"].ToString() + "<br>RIGHT : " + row1["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row1["ttleftchild"].ToString() + "<br>Right : " + row1["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row1["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row1["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row1["tnodename"].ToString() + "</td></tr><tr><td> $   " + row1["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row1["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row1["udate"].ToString() + "</td></tr><tr><td>Network Points,  LEFT : " + row1["ttleftpv"].ToString() + ", RIGHT : " + row1["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row1["ttleftchild"].ToString() + ", Right : " + row1["ttrightchild"].ToString() + "</table>";
                        Trees.span2 = "<img src=\"" + img(row1["ranks"].ToString()) + "\">";
                        Trees.span2id = row1["tnode_id"].ToString();
                        Trees.data2id = data;
                    Trees.name2id = row1["tnodename"].ToString();
                }


                    DataRow[] result2 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[0], c));
                    if ((result2.Count()) == 0 || result2 == null)
                    {
                        Trees.span3 = "<img src=\"" + im + "\"> ";
                        Trees.span3id = "Empty";
                        try
                        {
                            if (N[0].ToString().Length > 4)
                            {
                                Trees.span3 = "<img src=\"" + im + "\">";
                                Trees.span3id = "<a style=\"color:blue !important;\" href=\"register?id=" + N[0].ToString() + "&L=R\"> Create ID </a>";
                            }
                        }
                        catch
                        {
                        }
                    }
                    foreach (DataRow row2 in result2)
                    {
                        N[2] = row2["tnode_id"].ToString();
                        //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row2["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row2["tsponsor_id"].ToString() + "-" + row2["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row2["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row2["ttleftpv"].ToString() + "<br>RIGHT : " + row2["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row2["ttleftchild"].ToString() + "<br>Right : " + row2["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row2["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row2["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row2["tnodename"].ToString() + "</td></tr><tr><td> $   " + row2["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row2["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row2["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row2["ttleftpv"].ToString() + ", RIGHT : " + row2["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row2["ttleftchild"].ToString() + ", Right : " + row2["ttrightchild"].ToString() + "</table>";
                        Trees.span3 = "<img src=\"" + img(row2["ranks"].ToString()) + "\">";
                        Trees.span3id = row2["tnode_id"].ToString();
                        Trees.data3id = data;
                    Trees.name3id = row2["tnodename"].ToString();
                }


                    DataRow[] result3 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[1], b));
                    if ((result3.Count()) == 0 || result3 == null)
                    {
                        Trees.span4 = "<img src=\"" + im + "\">";
                        Trees.span4id = "Empty";
                        try
                        {


                            if (N[1].ToString().Length > 4)
                            {
                                Trees.span4 = "<img src=\"" + im + "\">";
                                Trees.span4id = "<a style=\"color:blue !important;\" href=\"register?id=" + N[1].ToString() + "&L=L\"> Create ID </a>";
                        }
                        }
                        catch
                        {

                        }

                    }
                    foreach (DataRow row4 in result3)
                    {
                        N[3] = row4["tnode_id"].ToString();
                        //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row4["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row4["tsponsor_id"].ToString() + "-" + row4["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row4["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row4["ttleftpv"].ToString() + "<br>RIGHT : " + row4["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row4["ttleftchild"].ToString() + "<br>Right : " + row4["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row4["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row4["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row4["tnodename"].ToString() + "</td></tr><tr><td> $   " + row4["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row4["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row4["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row4["ttleftpv"].ToString() + ", RIGHT : " + row4["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row4["ttleftchild"].ToString() + ", Right : " + row4["ttrightchild"].ToString() + "</table>";
                        Trees.span4 = "<img src=\"" + img(row4["ranks"].ToString()) + "\">";
                        Trees.span4id = row4["tnode_id"].ToString();
                        Trees.data4id = data;
                    Trees.name4id = row4["tnodename"].ToString();
                }

                    DataRow[] result4 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[1], c));
                    if ((result4.Count()) == 0 || result4 == null)
                    {
                        Trees.span5 = "<img src=\"" + im + "\"> ";
                        Trees.span5id = "Empty";
                        try
                        {

                            if (N[1].ToString().Length > 4)
                            {
                                Trees.span5 = "<img src=\"" + im + "\"> ";
                                Trees.span5id = "<a style=\"color:blue !important;\" href=\"register?id=" + N[1].ToString() + "&L=R\"> Create ID </a>";
                        }
                        }
                        catch
                        {

                        }
                    }
                    foreach (DataRow row5 in result4)
                    {
                        N[4] = row5["tnode_id"].ToString();
                        //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row5["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row5["tsponsor_id"].ToString() + "-" + row5["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row5["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row5["ttleftpv"].ToString() + "<br>RIGHT : " + row5["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row5["ttleftchild"].ToString() + "<br>Right : " + row5["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row5["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row5["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row5["tnodename"].ToString() + "</td></tr><tr><td> $   " + row5["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row5["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row5["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row5["ttleftpv"].ToString() + ", RIGHT : " + row5["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row5["ttleftchild"].ToString() + ", Right : " + row5["ttrightchild"].ToString() + "</table>";
                        Trees.span5 = "<img src=\"" + img(row5["ranks"].ToString()) + "\" >";
                        Trees.span5id = row5["tnode_id"].ToString();
                        Trees.data5id = data;
                    Trees.name5id = row5["tnodename"].ToString();
                }

                    DataRow[] result5 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[2], b));
                    if ((result5.Count()) == 0 || result5 == null)
                    {
                        Trees.span6 = "<img src=\"" + im + "\"> ";
                        Trees.span6id = "Empty";
                        try
                        {
                            if (N[2] != null)
                            {
                                if (N[2].ToString().Length > 4)
                                {
                                    Trees.span6 = "<img src=\"" + im + "\"> ";
                                    Trees.span6id = "<a style=\"color:blue !important;\" href=\"register?id=" + N[2].ToString() + "&L=L\"> Create ID </a>";
                            }
                            }
                            else
                            {
                                Trees.span6 = "<img src=\"" + im + "\"> ";
                                Trees.span6id = "Empty";
                            }
                        }
                        catch
                        {
                            Trees.span6 = "<img src=\"" + im + "\"> ";
                            Trees.span6id = "Empty";
                        }
                    }
                    foreach (DataRow row6 in result5)
                    {
                        N[5] = row6["tnode_id"].ToString();
                        //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row6["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row6["tsponsor_id"].ToString() + "-" + row6["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row6["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row6["ttleftpv"].ToString() + "<br>RIGHT : " + row6["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row6["ttleftchild"].ToString() + "<br>Right : " + row6["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row6["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row6["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row6["tnodename"].ToString() + "</td></tr><tr><td> $   " + row6["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row6["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row6["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row6["ttleftpv"].ToString() + ", RIGHT : " + row6["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row6["ttleftchild"].ToString() + ", Right : " + row6["ttrightchild"].ToString() + "</table>";
                        Trees.span6 = "<img src=\"" + img(row6["ranks"].ToString()) + "\">";
                        Trees.span6id = row6["tnode_id"].ToString();
                        Trees.data6id = data;
                    Trees.name6id = row6["tnodename"].ToString();
                }

                    DataRow[] result6 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[2], c));
                    if ((result6.Count()) == 0 || result6 == null)
                    {
                        Trees.span7 = "<img src=\"" + im + "\"> ";
                        Trees.span7id = "Empty";
                        try
                        {
                            if (N[2] != null)
                            {
                                if (N[2].ToString().Length > 4)
                                {
                                    Trees.span7 = "<img src=\"" + im + "\"> ";
                                    Trees.span7id = "<a style=\"color:blue !important;\" href=\"register?id=" + N[2].ToString() + "&L=R\"> Create ID </a>";
                            }
                            }
                            else
                            {
                                Trees.span7 = "<img src=\"" + im + "\"> ";
                                Trees.span7id = "Empty";
                            }
                        }
                        catch
                        {
                            Trees.span7 = "<img src=\"" + im + "\"> ";
                            Trees.span7id = "Empty";
                        }
                    }
                    foreach (DataRow row7 in result6)
                    {
                        N[6] = row7["tnode_id"].ToString();
                        //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row7["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row7["tsponsor_id"].ToString() + "-" + row7["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row7["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row7["ttleftpv"].ToString() + "<br>RIGHT : " + row7["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row7["ttleftchild"].ToString() + "<br>Right : " + row7["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row7["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row7["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row7["tnodename"].ToString() + "</td></tr><tr><td> $   " + row7["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row7["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row7["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row7["ttleftpv"].ToString() + ", RIGHT : " + row7["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row7["ttleftchild"].ToString() + ", Right : " + row7["ttrightchild"].ToString() + "</table>";
                        Trees.span7 = "<img src=\"" + img(row7["ranks"].ToString()) + "\">";
                        Trees.span7id = row7["tnode_id"].ToString();
                        Trees.data7id = data;
                    Trees.name7id = row7["tnodename"].ToString();
                }

                    DataRow[] result7 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[3], b));
                    if ((result7.Count()) == 0 || result7 == null)
                    {
                        Trees.span8 = "<img src=\"" + im + "\"> ";
                        Trees.span8id = "Empty";
                        try
                        {

                            if (N[3] != null)
                            {
                                if (N[3].ToString().Length > 4)
                                {
                                    Trees.span8 = "<img src=\"" + im + "\"> ";
                                    Trees.span8id = "<a style=\"color:blue !important;\" href=\"register?id=" + N[3].ToString() + "&L=L\"> Create ID </a>";
                            }
                            }
                            else
                            {
                                Trees.span8 = "<img src=\"" + im + "\"> ";
                                Trees.span8id = "Empty";
                            }
                        }
                        catch
                        {
                            Trees.span8 = "<img src=\"" + im + "\"> ";
                            Trees.span8id = "Empty";
                        }
                    }
                    foreach (DataRow row8 in result7)
                    {
                        N[7] = row8["tnode_id"].ToString();
                        //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row8["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row8["tsponsor_id"].ToString() + "-" + row8["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row8["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row8["ttleftpv"].ToString() + "<br>RIGHT : " + row8["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row8["ttleftchild"].ToString() + "<br>Right : " + row8["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row8["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row8["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row8["tnodename"].ToString() + "</td></tr><tr><td> $   " + row8["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row8["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row8["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row8["ttleftpv"].ToString() + ", RIGHT : " + row8["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row8["ttleftchild"].ToString() + ", Right : " + row8["ttrightchild"].ToString() + "</table>";
                        Trees.span8 = "<img src=\"" + img(row8["ranks"].ToString()) + "\" >";
                        Trees.span8id = row8["tnode_id"].ToString();
                        Trees.data8id = data;
                    Trees.name8id = row8["tnodename"].ToString();
                }

                    DataRow[] result8 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[3], c));
                    if ((result8.Count()) == 0 || result8 == null)
                    {
                        Trees.span9 = "<img src=\"" + im + "\"> ";
                        Trees.span9id = "Empty";
                        try
                        {
                            if (N[3] != null)
                            {

                                if (N[3].ToString().Length > 4)
                                {
                                    Trees.span9 = "<img src=\"" + im + "\"> ";
                                    Trees.span9id = "<a style=\"color:blue !important;\" href=\"register?id=" + N[3].ToString() + "&L=R\"> Create ID </a>";
                            }
                            }
                            else
                            {
                                Trees.span9 = "<img src=\"" + im + "\"> ";
                                Trees.span9id = "Empty";
                            }
                        }
                        catch
                        {

                        }
                    }
                    foreach (DataRow row9 in result8)
                    {
                        N[8] = row9["tnode_id"].ToString();
                        //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row9["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row9["tsponsor_id"].ToString() + "-" + row9["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row9["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row9["ttleftpv"].ToString() + "<br>RIGHT : " + row9["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row9["ttleftchild"].ToString() + "<br>Right : " + row9["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row9["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row9["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row9["tnodename"].ToString() + "</td></tr><tr><td> $   " + row9["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row9["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row9["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row9["ttleftpv"].ToString() + ", RIGHT : " + row9["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row9["ttleftchild"].ToString() + ", Right : " + row9["ttrightchild"].ToString() + "</table>";
                        Trees.span9 = "<img src=\"" + img(row9["ranks"].ToString()) + "\" >";
                        Trees.span9id = row9["tnode_id"].ToString();
                        Trees.data9id = data;
                    Trees.name9id = row9["tnodename"].ToString();
                }


                    DataRow[] result9 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[4], b));
                    if ((result9.Count()) == 0 || result9 == null)
                    {
                        Trees.span10 = "<img src=\"" + im + "\"> ";
                        Trees.span10id = "Empty";
                        try
                        {

                            if (N[4] != null)
                            {
                                if (N[4].ToString().Length > 4)
                                {
                                    Trees.span10 = "<img src=\"" + im + "\"> ";
                                    Trees.span10id = "<a style=\"color:blue !important;\" href=\"register?id=" + N[4].ToString() + "&L=L\"> Create ID </a>";
                            }
                            }
                            else
                            {
                                Trees.span10 = "<img src=\"" + im + "\"> ";
                                Trees.span10id = "Empty";
                            }
                        }
                        catch
                        {

                        }
                    }
                    foreach (DataRow row10 in result9)
                    {
                        N[9] = row10["tnode_id"].ToString();
                        //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row10["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row10["tsponsor_id"].ToString() + "-" + row10["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row10["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row10["ttleftpv"].ToString() + "<br>RIGHT : " + row10["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row10["ttleftchild"].ToString() + "<br>Right : " + row10["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row10["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row10["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row10["tnodename"].ToString() + "</td></tr><tr><td> $   " + row10["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row10["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row10["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row10["ttleftpv"].ToString() + ", RIGHT : " + row10["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row10["ttleftchild"].ToString() + ", Right : " + row10["ttrightchild"].ToString() + "</table>";
                        Trees.span10 = "<img src=\"" + img(row10["ranks"].ToString()) + "\" >";
                        Trees.span10id = row10["tnode_id"].ToString();
                        Trees.data10id = data;
                    Trees.name10id = row10["tnodename"].ToString();
                }

                    DataRow[] result10 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[4], c));
                    if ((result10.Count()) == 0 || result10 == null)
                    {
                        Trees.span11 = "<img src=\"" + im + "\"> ";
                        Trees.span11id = "Empty";
                        try
                        {
                            if (N[4] != null)
                            {
                                if (N[4].ToString().Length > 4)
                                {
                                    Trees.span11 = "<img src=\"" + im + "\"> ";
                                    Trees.span11id = "<a style=\"color:blue !important;\" href=\"register?id=" + N[4].ToString() + "&L=R\"> Create ID </a>";
                            }
                            }
                            else
                            {
                                Trees.span11 = "<img src=\"" + im + "\"> ";
                                Trees.span11id = "Empty";
                            }
                        }
                        catch
                        {

                        }
                    }
                    foreach (DataRow row11 in result10)
                    {
                        N[10] = row11["tnode_id"].ToString();
                        //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row11["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row11["tsponsor_id"].ToString() + "-" + row11["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row11["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row11["ttleftpv"].ToString() + "<br>RIGHT : " + row11["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row11["ttleftchild"].ToString() + "<br>Right : " + row11["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row11["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row11["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row11["tnodename"].ToString() + "</td></tr><tr><td> $   " + row11["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row11["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row11["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row11["ttleftpv"].ToString() + ", RIGHT : " + row11["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row11["ttleftchild"].ToString() + ", Right : " + row11["ttrightchild"].ToString() + "</table>";
                        Trees.span11 = "<img src=\"" + img(row11["ranks"].ToString()) + "\" >";
                        Trees.span11id = row11["tnode_id"].ToString();
                        Trees.data11id = data;
                    Trees.name11id = row11["tnodename"].ToString();
                }

                    DataRow[] result11 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[5], b));
                    if ((result11.Count()) == 0 || result11 == null)
                    {
                        Trees.span12 = "<img src=\"" + im + "\"> ";
                        Trees.span12id = "Empty";
                        try
                        {
                            if (N[5] != null)
                            {
                                if (N[5].ToString().Length > 4)
                                {
                                    Trees.span12 = "<img src=\"" + im + "\"> ";
                                    Trees.span12id = "<a style=\"color:blue !important;\" href=\"register?id=" + N[5].ToString() + "&L=L\"> Create ID </a>";
                            }
                            }
                            else
                            {
                                Trees.span12 = "<img src=\"" + im + "\"> ";
                                Trees.span12id = "Empty";
                            }
                        }
                        catch
                        {

                        }
                    }
                    foreach (DataRow row12 in result11)
                    {
                        N[11] = row12["tnode_id"].ToString();
                        //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row12["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row12["tsponsor_id"].ToString() + "-" + row12["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row12["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row12["ttleftpv"].ToString() + "<br>RIGHT : " + row12["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row12["ttleftchild"].ToString() + "<br>Right : " + row12["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row12["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row12["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row12["tnodename"].ToString() + "</td></tr><tr><td> $   " + row12["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row12["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row12["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row12["ttleftpv"].ToString() + ", RIGHT : " + row12["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row12["ttleftchild"].ToString() + ", Right : " + row12["ttrightchild"].ToString() + "</table>";
                        Trees.span12 = "<img src=\"" + img(row12["ranks"].ToString()) + "\"> ";
                        Trees.span12id = row12["tnode_id"].ToString();
                        Trees.data12id = data;
                    Trees.name12id = row12["tnodename"].ToString();
                }

                    DataRow[] result12 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[5], c));
                    if ((result12.Count()) == 0 || result12 == null)
                    {
                        Trees.span13 = "<img src=\"" + im + "\"> ";
                        Trees.span13id = "Empty";
                        try
                        {

                            if (N[5] != null)
                            {
                                if (N[5].ToString().Length > 4)
                                {
                                    Trees.span13 = "<img src=\"" + im + "\"> ";
                                    Trees.span13id = "<a style=\"color:blue !important;\" href=\"register?id=" + N[5].ToString() + "&L=R\"> Create ID </a>";
                            }
                            }
                            else
                            {
                                Trees.span13 = "<img src=\"" + im + "\"> ";
                                Trees.span13id = "Empty";
                            }
                        }
                        catch
                        {

                        }
                    }
                    foreach (DataRow row13 in result12)
                    {
                        N[12] = row13["tnode_id"].ToString();
                        //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row13["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row13["tsponsor_id"].ToString() + "-" + row13["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row13["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row13["ttleftpv"].ToString() + "<br>RIGHT : " + row13["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row13["ttleftchild"].ToString() + "<br>Right : " + row13["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row13["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row13["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row13["tnodename"].ToString() + "</td></tr><tr><td> Package $   " + row13["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row13["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row13["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row13["ttleftpv"].ToString() + ", RIGHT : " + row13["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row13["ttleftchild"].ToString() + ", Right : " + row13["ttrightchild"].ToString() + "</table>";
                        Trees.span13 = "<img src=\"" + img(row13["ranks"].ToString()) + "\" >";
                        Trees.span13id = row13["tnode_id"].ToString();
                        Trees.data13id = data;
                    Trees.name13id = row13["tnodename"].ToString();
                }

                    DataRow[] result13 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[6], b));
                    if ((result13.Count()) == 0 || result13 == null)
                    {
                        Trees.span14 = "<img src=\"" + im + "\"> ";
                        Trees.span14id = "Empty";
                        try
                        {
                            if (N[6] != null)
                            {

                                if (N[6].ToString().Length > 4)
                                {
                                    Trees.span14 = "<img src=\"" + im + "\"> ";
                                    Trees.span14id = "<a style=\"color:blue !important;\" href=\"register?id=" + N[6].ToString() + "&L=L\"> Create ID </a>";
                            }
                            }
                            else
                            {
                                Trees.span14 = "<img src=\"" + im + "\"> ";
                                Trees.span14id = "Empty";
                            }
                        }
                        catch
                        {

                        }
                    }
                    foreach (DataRow row14 in result13)
                    {
                        N[9] = row14["tnode_id"].ToString();
                        //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row14["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row14["tsponsor_id"].ToString() + "-" + row14["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row14["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row14["ttleftpv"].ToString() + "<br>RIGHT : " + row14["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row14["ttleftchild"].ToString() + "<br>Right : " + row14["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row14["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row14["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row14["tnodename"].ToString() + "</td></tr><tr><td> $   " + row14["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row14["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row14["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row14["ttleftpv"].ToString() + ", RIGHT : " + row14["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row14["ttleftchild"].ToString() + ", Right : " + row14["ttrightchild"].ToString() + "</table>";
                        Trees.span14 = "<img src=\"" + img(row14["ranks"].ToString()) + "\" >";
                        Trees.span14id = row14["tnode_id"].ToString();
                        Trees.data14id = data;
                    Trees.name14id = row14["tnodename"].ToString();
                }

                    DataRow[] result14 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[6], c));
                    if ((result14.Count()) == 0 || result14 == null)
                    {
                        Trees.span15 = "<img src=\"" + im + "\"> ";
                        Trees.span15id = "Empty";
                        try
                        {
                            if (N[6] != null)
                            {

                                if (N[6].ToString().Length > 4)
                                {
                                    Trees.span15 = "<img src=\"" + im + "\"> ";
                                    Trees.span15id = "<a style=\"color:blue !important;\" href=\"register?id=" + N[6].ToString() + "&L=R\"> Create ID </a>";
                            }
                            }
                            else
                            {
                                Trees.span15 = "<img src=\"" + im + "\"> ";
                                Trees.span15id = "Empty";
                            }
                        }
                        catch
                        {

                        }
                    }
                    foreach (DataRow row15 in result14)
                    {
                        N[10] = row15["tnode_id"].ToString();
                        //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row15["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row15["tsponsor_id"].ToString() + "-" + row15["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row15["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row15["ttleftpv"].ToString() + "<br>RIGHT : " + row15["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row15["ttleftchild"].ToString() + "<br>Right : " + row15["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row15["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row15["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row15["tnodename"].ToString() + "</td></tr><tr><td> $   " + row15["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row15["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row15["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row15["ttleftpv"].ToString() + ", RIGHT : " + row15["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row15["ttleftchild"].ToString() + ", Right : " + row15["ttrightchild"].ToString() + "</table>";
                        Trees.span15 = "<img src=\"" + img(row15["ranks"].ToString()) + "\"> ";
                        Trees.span15id = row15["tnode_id"].ToString();
                        Trees.data15id = data;
                    Trees.name15id = row15["tnodename"].ToString();
                }

                }
                return Trees;
            }
            public TreeView GetadminAlltree(string connectionString)
            {
                string im = "/../images/iconman.jpg";
                TreeView Trees = new TreeView();
                var IncomeList = new List<Income>();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string[] N = new string[18];
                    SqlCommand cmd = new SqlCommand("prosnodecheck", con)
                    {
                        CommandType = CommandType.StoredProcedure

                    };
                    con.Open();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;
                    cmd.Parameters.AddWithValue("@parentid", "11111111");
                    cmd.Parameters.AddWithValue("@checkid", "11111111");
                    SqlDataAdapter dataAdapter2 = new SqlDataAdapter(cmd);
                    DataSet dataSet2 = new DataSet();
                    dataAdapter2.Fill(dataSet2);
                    if (dataSet2.Tables[0].Rows[0][0].ToString() == "0" && "11111111" != "11111111")
                    {
                        Trees.span1 = "<center>Not Associates with this id !.</center>";
                        con.Close();

                    }

                    SqlCommand cmd2 = new SqlCommand("[lbinaryplanB]", con);
                    // SqlCommand cmd = new SqlCommand("pro_selete_nodetable", con);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.CommandTimeout = 0;
                    cmd2.Parameters.AddWithValue("@referid", "11111111");
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd2);
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    con.Close();
                    string a = "11111111";
                    string b = "%L%";
                    string c = "%R%";

                    DataRow[] result = dataSet.Tables[0].Select(string.Format("tnode_id='{0}'", a));
                    if ((result.Count()) == 0 || result == null)
                    {

                        Trees.span1 = "<img src=\"" + im + "\"> ";
                        Trees.span1id = "Create ID";
                    }
                    foreach (DataRow row in result)
                    {
                        N[0] = row["tnode_id"].ToString();
                        string data = "<table class='table table-border'><tr><td>Name : " + row["tnodename"].ToString() + "<br>Current Rank : " + row["ranks"].ToString() + "<br>Sponsor : " + row["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row["ttleftpv"].ToString() + ", RIGHT : " + row["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row["ttleftchild"].ToString() + ", Right : " + row["ttrightchild"].ToString() + "</table>";
                        Trees.span1 = "<img src=\"" + img(row["ranks"].ToString()) + "\"> ";
                        Trees.span1id = row["tnode_id"].ToString();
                    }

                    DataRow[] result1 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[0], b));
                    if ((result1.Count()) == 0 || result1 == null)
                    {

                        Trees.span2 = "<img src=\"" + im + "\"> ";
                        Trees.span2id = "Create ID";
                        try
                        {
                            if (N[0].ToString().Length > 4)
                            {
                                Trees.span2 = "<img src=\"" + im + "\"> ";
                                Trees.span2id = "Create ID";
                            }
                        }
                        catch
                        {

                        }

                    }
                    foreach (DataRow row1 in result1)
                    {
                        N[1] = row1["tnode_id"].ToString();
                        //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row1["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row1["tsponsor_id"].ToString() + "-" + row1["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row1["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row1["ttleftpv"].ToString() + "<br>RIGHT : " + row1["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row1["ttleftchild"].ToString() + "<br>Right : " + row1["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row1["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row1["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row1["tnodename"].ToString() + "<br>Current Rank : " + row1["ranks"].ToString() + "<br>Sponsor : " + row1["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row1["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row1["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row1["udate"].ToString() + "</td></tr><tr><td>Network Points,  LEFT : " + row1["ttleftpv"].ToString() + ", RIGHT : " + row1["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row1["ttleftchild"].ToString() + ", Right : " + row1["ttrightchild"].ToString() + "</table>";
                        Trees.span2 = "<img src=\"" + img(row1["ranks"].ToString()) + "\">";
                        Trees.span2id = row1["tnode_id"].ToString();
                    }


                    DataRow[] result2 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[0], c));
                    if ((result2.Count()) == 0 || result2 == null)
                    {
                        Trees.span3 = "<img src=\"" + im + "\"> ";
                        Trees.span3id = "Create ID";
                        try
                        {
                            if (N[0].ToString().Length > 4)
                            {
                                Trees.span3 = "<img src=\"" + im + "\"> ";
                                Trees.span3id = "Create ID";
                            }
                        }
                        catch
                        {
                        }
                    }
                    foreach (DataRow row2 in result2)
                    {
                        N[2] = row2["tnode_id"].ToString();
                        //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row2["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row2["tsponsor_id"].ToString() + "-" + row2["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row2["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row2["ttleftpv"].ToString() + "<br>RIGHT : " + row2["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row2["ttleftchild"].ToString() + "<br>Right : " + row2["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row2["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row2["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row2["tnodename"].ToString() + "<br>Current Rank : " + row2["ranks"].ToString() + "<br>Sponsor : " + row2["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row2["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row2["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row2["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row2["ttleftpv"].ToString() + ", RIGHT : " + row2["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row2["ttleftchild"].ToString() + ", Right : " + row2["ttrightchild"].ToString() + "</table>";
                        Trees.span3 = "<img src=\"" + img(row2["ranks"].ToString()) + "\"";
                        Trees.span3id = row2["tnode_id"].ToString();
                    }


                    DataRow[] result3 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[1], b));
                    if ((result3.Count()) == 0 || result3 == null)
                    {
                        Trees.span4 = "<img src=\"" + im + "\"> ";
                        Trees.span4id = "Create ID";
                        try
                        {


                            if (N[1].ToString().Length > 4)
                            {
                                Trees.span4 = "<img src=\"" + im + "\"> ";
                                Trees.span4id = "Create ID";
                            }
                        }
                        catch
                        {

                        }

                    }
                    foreach (DataRow row4 in result3)
                    {
                        N[3] = row4["tnode_id"].ToString();
                        //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row4["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row4["tsponsor_id"].ToString() + "-" + row4["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row4["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row4["ttleftpv"].ToString() + "<br>RIGHT : " + row4["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row4["ttleftchild"].ToString() + "<br>Right : " + row4["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row4["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row4["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row4["tnodename"].ToString() + "<br>Current Rank : " + row4["ranks"].ToString() + "<br>Sponsor : " + row4["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row4["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row4["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row4["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row4["ttleftpv"].ToString() + ", RIGHT : " + row4["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row4["ttleftchild"].ToString() + ", Right : " + row4["ttrightchild"].ToString() + "</table>";
                        Trees.span4 = "<img src=\"" + img(row4["ranks"].ToString()) + "\"";
                        Trees.span4id = row4["tnode_id"].ToString();
                    }

                    DataRow[] result4 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[1], c));
                    if ((result4.Count()) == 0 || result4 == null)
                    {
                        Trees.span5 = "<img src=\"" + im + "\"> ";
                        Trees.span5id = "Create ID";
                        try
                        {

                            if (N[1].ToString().Length > 4)
                            {
                                Trees.span5 = "<img src=\"" + im + "\"> ";
                                Trees.span5id = "Create ID";
                            }
                        }
                        catch
                        {

                        }
                    }
                    foreach (DataRow row5 in result4)
                    {
                        N[4] = row5["tnode_id"].ToString();
                        //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row5["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row5["tsponsor_id"].ToString() + "-" + row5["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row5["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row5["ttleftpv"].ToString() + "<br>RIGHT : " + row5["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row5["ttleftchild"].ToString() + "<br>Right : " + row5["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row5["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row5["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row5["tnodename"].ToString() + "<br>Current Rank : " + row5["ranks"].ToString() + "<br>Sponsor : " + row5["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row5["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row5["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row5["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row5["ttleftpv"].ToString() + ", RIGHT : " + row5["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row5["ttleftchild"].ToString() + ", Right : " + row5["ttrightchild"].ToString() + "</table>";
                        Trees.span5 = "<img src=\"" + img(row5["ranks"].ToString()) + "\" ";
                        Trees.span5id = row5["tnode_id"].ToString();
                    }

                    DataRow[] result5 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[2], b));
                    if ((result5.Count()) == 0 || result5 == null)
                    {
                        Trees.span6 = "<img src=\"" + im + "\"> ";
                        Trees.span6id = "Create ID";
                        try
                        {
                            if (N[2] != null)
                            {
                                if (N[2].ToString().Length > 4)
                                {
                                    Trees.span6 = "<img src=\"" + im + "\"> ";
                                    Trees.span6id = "Create ID";
                                }
                            }
                            else
                            {
                                Trees.span6 = "<img src=\"" + im + "\"> ";
                                Trees.span6id = "Create ID";
                            }
                        }
                        catch
                        {
                            Trees.span6 = "<img src=\"" + im + "\"> ";
                            Trees.span6id = "Create ID";
                        }
                    }
                    foreach (DataRow row6 in result5)
                    {
                        N[5] = row6["tnode_id"].ToString();
                        //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row6["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row6["tsponsor_id"].ToString() + "-" + row6["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row6["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row6["ttleftpv"].ToString() + "<br>RIGHT : " + row6["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row6["ttleftchild"].ToString() + "<br>Right : " + row6["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row6["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row6["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row6["tnodename"].ToString() + "<br>Current Rank : " + row6["ranks"].ToString() + "<br>Sponsor : " + row6["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row6["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row6["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row6["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row6["ttleftpv"].ToString() + ", RIGHT : " + row6["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row6["ttleftchild"].ToString() + ", Right : " + row6["ttrightchild"].ToString() + "</table>";
                        Trees.span6 = "<img src=\"" + img(row6["ranks"].ToString()) + "\"  ";
                        Trees.span6id = row6["tnode_id"].ToString();
                    }

                    DataRow[] result6 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[2], c));
                    if ((result6.Count()) == 0 || result6 == null)
                    {
                        Trees.span7 = "<img src=\"" + im + "\"> ";
                        Trees.span7id = "Create ID";
                        try
                        {
                            if (N[2] != null)
                            {
                                if (N[2].ToString().Length > 4)
                                {
                                    Trees.span7 = "<img src=\"" + im + "\"> ";
                                    Trees.span7id = "Create ID";
                                }
                            }
                            else
                            {
                                Trees.span7 = "<img src=\"" + im + "\"> ";
                                Trees.span7id = "Create ID";
                            }
                        }
                        catch
                        {
                            Trees.span7 = "<img src=\"" + im + "\"> ";
                            Trees.span7id = "Create ID";
                        }
                    }
                    foreach (DataRow row7 in result6)
                    {
                        N[6] = row7["tnode_id"].ToString();
                        //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row7["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row7["tsponsor_id"].ToString() + "-" + row7["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row7["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row7["ttleftpv"].ToString() + "<br>RIGHT : " + row7["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row7["ttleftchild"].ToString() + "<br>Right : " + row7["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row7["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row7["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row7["tnodename"].ToString() + "<br>Current Rank : " + row7["ranks"].ToString() + "<br>Sponsor : " + row7["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row7["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row7["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row7["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row7["ttleftpv"].ToString() + ", RIGHT : " + row7["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row7["ttleftchild"].ToString() + ", Right : " + row7["ttrightchild"].ToString() + "</table>";
                        Trees.span7 = "<img src=\"" + img(row7["ranks"].ToString()) + "\"  ";
                        Trees.span7id = row7["tnode_id"].ToString();
                    }

                    DataRow[] result7 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[3], b));
                    if ((result7.Count()) == 0 || result7 == null)
                    {
                        Trees.span8 = "<img src=\"" + im + "\"> ";
                        Trees.span8id = "Create ID";
                        try
                        {

                            if (N[3] != null)
                            {
                                if (N[3].ToString().Length > 4)
                                {
                                    Trees.span8 = "<img src=\"" + im + "\"> ";
                                    Trees.span8id = "Create ID";
                                }
                            }
                            else
                            {
                                Trees.span8 = "<img src=\"" + im + "\"> ";
                                Trees.span8id = "Create ID";
                            }
                        }
                        catch
                        {
                            Trees.span8 = "<img src=\"" + im + "\"> ";
                            Trees.span8id = "Create ID";
                        }
                    }
                    foreach (DataRow row8 in result7)
                    {
                        N[7] = row8["tnode_id"].ToString();
                        //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row8["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row8["tsponsor_id"].ToString() + "-" + row8["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row8["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row8["ttleftpv"].ToString() + "<br>RIGHT : " + row8["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row8["ttleftchild"].ToString() + "<br>Right : " + row8["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row8["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row8["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row8["tnodename"].ToString() + "<br>Current Rank : " + row8["ranks"].ToString() + "<br>Sponsor : " + row8["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row8["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row8["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row8["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row8["ttleftpv"].ToString() + ", RIGHT : " + row8["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row8["ttleftchild"].ToString() + ", Right : " + row8["ttrightchild"].ToString() + "</table>";
                        Trees.span8 = "<img src=\"" + img(row8["ranks"].ToString()) + "\" ";
                        Trees.span8id = row8["tnode_id"].ToString();
                    }

                    DataRow[] result8 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[3], c));
                    if ((result8.Count()) == 0 || result8 == null)
                    {
                        Trees.span9 = "<img src=\"" + im + "\"> ";
                        Trees.span9id = "Create ID";
                        try
                        {
                            if (N[3] != null)
                            {

                                if (N[3].ToString().Length > 4)
                                {
                                    Trees.span9 = "<img src=\"" + im + "\"> ";
                                    Trees.span9id = "Create ID";
                                }
                            }
                            else
                            {
                                Trees.span9 = "<img src=\"" + im + "\"> ";
                                Trees.span9id = "Create ID";
                            }
                        }
                        catch
                        {

                        }
                    }
                    foreach (DataRow row9 in result8)
                    {
                        N[8] = row9["tnode_id"].ToString();
                        //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row9["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row9["tsponsor_id"].ToString() + "-" + row9["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row9["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row9["ttleftpv"].ToString() + "<br>RIGHT : " + row9["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row9["ttleftchild"].ToString() + "<br>Right : " + row9["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row9["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row9["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row9["tnodename"].ToString() + "<br>Current Rank : " + row9["ranks"].ToString() + "<br>Sponsor : " + row9["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row9["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row9["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row9["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row9["ttleftpv"].ToString() + ", RIGHT : " + row9["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row9["ttleftchild"].ToString() + ", Right : " + row9["ttrightchild"].ToString() + "</table>";
                        Trees.span9 = "<img src=\"" + img(row9["ranks"].ToString()) + "\" ";
                        Trees.span9id = row9["tnode_id"].ToString();
                    }


                    DataRow[] result9 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[4], b));
                    if ((result9.Count()) == 0 || result9 == null)
                    {
                        Trees.span10 = "<img src=\"" + im + "\"> ";
                        Trees.span10id = "Create ID";
                        try
                        {

                            if (N[4] != null)
                            {
                                if (N[4].ToString().Length > 4)
                                {
                                    Trees.span10 = "<img src=\"" + im + "\"> ";
                                    Trees.span10id = "Create ID";
                                }
                            }
                            else
                            {
                                Trees.span10 = "<img src=\"" + im + "\"> ";
                                Trees.span10id = "Create ID";
                            }
                        }
                        catch
                        {

                        }
                    }
                    foreach (DataRow row10 in result9)
                    {
                        N[9] = row10["tnode_id"].ToString();
                        //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row10["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row10["tsponsor_id"].ToString() + "-" + row10["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row10["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row10["ttleftpv"].ToString() + "<br>RIGHT : " + row10["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row10["ttleftchild"].ToString() + "<br>Right : " + row10["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row10["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row10["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row10["tnodename"].ToString() + "<br>Current Rank : " + row10["ranks"].ToString() + "<br>Sponsor : " + row10["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row10["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row10["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row10["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row10["ttleftpv"].ToString() + ", RIGHT : " + row10["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row10["ttleftchild"].ToString() + ", Right : " + row10["ttrightchild"].ToString() + "</table>";
                        Trees.span10 = "<img src=\"" + img(row10["ranks"].ToString()) + "\" ";
                        Trees.span10id = row10["tnode_id"].ToString();
                    }

                    DataRow[] result10 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[4], c));
                    if ((result10.Count()) == 0 || result10 == null)
                    {
                        Trees.span11 = "<img src=\"" + im + "\"> ";
                        Trees.span11id = "Create ID";
                        try
                        {
                            if (N[4] != null)
                            {
                                if (N[4].ToString().Length > 4)
                                {
                                    Trees.span11 = "<img src=\"" + im + "\"> ";
                                    Trees.span11id = "Create ID";
                                }
                            }
                            else
                            {
                                Trees.span11 = "<img src=\"" + im + "\"> ";
                                Trees.span11id = "Create ID";
                            }
                        }
                        catch
                        {

                        }
                    }
                    foreach (DataRow row11 in result10)
                    {
                        N[10] = row11["tnode_id"].ToString();
                        //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row11["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row11["tsponsor_id"].ToString() + "-" + row11["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row11["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row11["ttleftpv"].ToString() + "<br>RIGHT : " + row11["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row11["ttleftchild"].ToString() + "<br>Right : " + row11["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row11["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row11["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row11["tnodename"].ToString() + "<br>Current Rank : " + row11["ranks"].ToString() + "<br>Sponsor : " + row11["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row11["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row11["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row11["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row11["ttleftpv"].ToString() + ", RIGHT : " + row11["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row11["ttleftchild"].ToString() + ", Right : " + row11["ttrightchild"].ToString() + "</table>";
                        Trees.span11 = "<img src=\"" + img(row11["ranks"].ToString()) + "\" ";
                        Trees.span11id = row11["tnode_id"].ToString();
                    }

                    DataRow[] result11 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[5], b));
                    if ((result11.Count()) == 0 || result11 == null)
                    {
                        Trees.span12 = "<img src=\"" + im + "\"> ";
                        Trees.span12id = "Create ID";
                        try
                        {
                            if (N[4] != null)
                            {
                                if (N[5].ToString().Length > 4)
                                {
                                    Trees.span12 = "<img src=\"" + im + "\"> ";
                                    Trees.span12id = "Create ID";
                                }
                            }
                            else
                            {
                                Trees.span12 = "<img src=\"" + im + "\"> ";
                                Trees.span12id = "Create ID";
                            }
                        }
                        catch
                        {

                        }
                    }
                    foreach (DataRow row12 in result11)
                    {
                        N[11] = row12["tnode_id"].ToString();
                        //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row12["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row12["tsponsor_id"].ToString() + "-" + row12["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row12["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row12["ttleftpv"].ToString() + "<br>RIGHT : " + row12["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row12["ttleftchild"].ToString() + "<br>Right : " + row12["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row12["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row12["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row12["tnodename"].ToString() + "<br>Current Rank : " + row12["ranks"].ToString() + "<br>Sponsor : " + row12["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row12["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row12["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row12["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row12["ttleftpv"].ToString() + ", RIGHT : " + row12["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row12["ttleftchild"].ToString() + ", Right : " + row12["ttrightchild"].ToString() + "</table>";
                        Trees.span12 = "<img src=\"" + img(row12["ranks"].ToString()) + "\" ";
                        Trees.span12id = row12["tnode_id"].ToString();
                    }

                    DataRow[] result12 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[5], c));
                    if ((result12.Count()) == 0 || result12 == null)
                    {
                        Trees.span13 = "<img src=\"" + im + "\"> ";
                        Trees.span13id = "Create ID";
                        try
                        {

                            if (N[5] != null)
                            {
                                if (N[5].ToString().Length > 4)
                                {
                                    Trees.span13 = "<img src=\"" + im + "\"> ";
                                    Trees.span13id = "Create ID";
                                }
                            }
                            else
                            {
                                Trees.span13 = "<img src=\"" + im + "\"> ";
                                Trees.span13id = "Create ID";
                            }
                        }
                        catch
                        {

                        }
                    }
                    foreach (DataRow row13 in result12)
                    {
                        N[12] = row13["tnode_id"].ToString();
                        //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row13["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row13["tsponsor_id"].ToString() + "-" + row13["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row13["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row13["ttleftpv"].ToString() + "<br>RIGHT : " + row13["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row13["ttleftchild"].ToString() + "<br>Right : " + row13["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row13["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row13["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row13["tnodename"].ToString() + "<br>Current Rank : " + row13["ranks"].ToString() + "<br>Sponsor : " + row13["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row13["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row13["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row13["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row13["ttleftpv"].ToString() + ", RIGHT : " + row13["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row13["ttleftchild"].ToString() + ", Right : " + row13["ttrightchild"].ToString() + "</table>";
                        Trees.span13 = "<img src=\"" + img(row13["ranks"].ToString()) + "\" ";
                        Trees.span13id = row13["tnode_id"].ToString();
                    }

                    DataRow[] result13 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[6], b));
                    if ((result13.Count()) == 0 || result13 == null)
                    {
                        Trees.span14 = "<img src=\"" + im + "\"> ";
                        Trees.span14id = "Create ID";
                        try
                        {
                            if (N[6] != null)
                            {

                                if (N[6].ToString().Length > 4)
                                {
                                    Trees.span14 = "<img src=\"" + im + "\"> ";
                                    Trees.span14id = "Create ID";
                                }
                            }
                            else
                            {
                                Trees.span14 = "<img src=\"" + im + "\"> ";
                                Trees.span14id = "Create ID";
                            }
                        }
                        catch
                        {

                        }
                    }
                    foreach (DataRow row14 in result13)
                    {
                        N[9] = row14["tnode_id"].ToString();
                        //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row14["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row14["tsponsor_id"].ToString() + "-" + row14["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row14["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row14["ttleftpv"].ToString() + "<br>RIGHT : " + row14["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row14["ttleftchild"].ToString() + "<br>Right : " + row14["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row14["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row14["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row14["tnodename"].ToString() + "<br>Current Rank : " + row14["ranks"].ToString() + "<br>Sponsor : " + row14["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row14["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row14["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row14["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row14["ttleftpv"].ToString() + ", RIGHT : " + row14["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row14["ttleftchild"].ToString() + ", Right : " + row14["ttrightchild"].ToString() + "</table>";
                        Trees.span14 = "<img src=\"" + img(row14["ranks"].ToString()) + "\" ";
                        Trees.span14id = row14["tnode_id"].ToString();
                    }

                    DataRow[] result14 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[6], c));
                    if ((result14.Count()) == 0 || result14 == null)
                    {
                        Trees.span15 = "<img src=\"" + im + "\"> ";
                        Trees.span15id = "Create ID";
                        try
                        {
                            if (N[6] != null)
                            {

                                if (N[6].ToString().Length > 4)
                                {
                                    Trees.span15 = "<img src=\"" + im + "\"> ";
                                    Trees.span15id = "Create ID";
                                }
                            }
                            else
                            {
                                Trees.span15 = "<img src=\"" + im + "\"> ";
                                Trees.span15id = "Create ID";
                            }
                        }
                        catch
                        {

                        }
                    }
                    foreach (DataRow row15 in result14)
                    {
                        N[10] = row15["tnode_id"].ToString();
                        //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row15["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row15["tsponsor_id"].ToString() + "-" + row15["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row15["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row15["ttleftpv"].ToString() + "<br>RIGHT : " + row15["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row15["ttleftchild"].ToString() + "<br>Right : " + row15["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row15["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row15["udate"].ToString() + "</td></tr></table>";
                        string data = "<table class='table table-border'><tr><td>Name : " + row15["tnodename"].ToString() + "<br>Current Rank : " + row15["ranks"].ToString() + "<br>Sponsor : " + row15["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row15["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row15["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row15["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row15["ttleftpv"].ToString() + ", RIGHT : " + row15["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row15["ttleftchild"].ToString() + ", Right : " + row15["ttrightchild"].ToString() + "</table>";
                        Trees.span15 = "<img src=\"" + img(row15["ranks"].ToString()) + "\" ";
                        Trees.span15id = row15["tnode_id"].ToString();
                    }

                }
                return Trees;
            }

        public Dashboard GetAlldashboardtree(string connectionString, string uid)
        {
            string im = "/../Tree_img/t1.png";
            Dashboard Trees = new Dashboard();
            var IncomeList = new List<Income>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string[] N = new string[18];
                SqlCommand cmd = new SqlCommand("prosnodecheck", con)
                {
                    CommandType = CommandType.StoredProcedure

                };
                con.Open();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.AddWithValue("@parentid", uid);
                cmd.Parameters.AddWithValue("@checkid", uid);
                SqlDataAdapter dataAdapter2 = new SqlDataAdapter(cmd);
                DataSet dataSet2 = new DataSet();
                dataAdapter2.Fill(dataSet2);
                if (dataSet2.Tables[0].Rows[0][0].ToString() == "0" && uid != uid)
                {
                    Trees.span1 = "<center>Not Associates with this id !.</center>";
                    con.Close();

                }

                SqlCommand cmd2 = new SqlCommand("[lbinaryplanB]", con);
                // SqlCommand cmd = new SqlCommand("pro_selete_nodetable", con);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.CommandTimeout = 0;
                cmd2.Parameters.AddWithValue("@referid", uid);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd2);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                con.Close();
                string a = uid;
                string b = "%L%";
                string c = "%R%";

                DataRow[] result = dataSet.Tables[0].Select(string.Format("tnode_id='{0}'", a));
                if ((result.Count()) == 0 || result == null)
                {

                    Trees.span1 = "<img src=\"" + im + "\"> ";
                    Trees.span1id = "Create ID";
                }
                foreach (DataRow row in result)
                {
                    N[0] = row["tnode_id"].ToString();
                    //lbl1.Text = "Left Child : " + row["ttleftchild"].ToString();
                    //lbl2.Text = "Left Child : " + row["ttleftpv"].ToString();
                    //lbl3.Text = "Star Magic Left : " + row["ttspill_c"].ToString();
                    //lbl4.Text = "Right Child : " + row["ttrightchild"].ToString();
                    //lbl5.Text = "Right Child : " + row["ttrightpv"].ToString();
                    //lbl6.Text = "Star Magic Right : " + row["ttspill_d"].ToString();

                    //string data = "<table><tr><td class='success'> Name </td> <td>  " + row["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row["tsponsor_id"].ToString() + "-" + row["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row["ttleftpv"].ToString() + "<br>RIGHT : " + row["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row["ttleftchild"].ToString() + "<br>Right : " + row["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $   " + row["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row["udate"].ToString() + "</td></tr></table>";
                    string data = "<table class='table table-border'><tr><td>Name : " + row["tnodename"].ToString() + "<br>Current Rank : " + row["Ranks"].ToString() + "<br>Sponsor : " + row["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row["ttleftpv"].ToString() + ", RIGHT : " + row["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row["leftleg"].ToString() + ", Right : " + row["rightleg"].ToString() + "</table>";
                    Trees.span1 = "<img src=\"" + img(row["Ranks"].ToString()) + "\"> ";
                    Trees.span1id = row["tnode_id"].ToString();
                }

                DataRow[] result1 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[0], b));
                if ((result1.Count()) == 0 || result1 == null)
                {

                    Trees.span2 = "<img src=\"" + im + "\"> ";
                    Trees.span2id = "Create ID";
                    try
                    {
                        if (N[0].ToString().Length > 4)
                        {
                            Trees.span2 = "<img src=\"" + im + "\"> ";
                            Trees.span2id = "JOIN NOW";
                        }
                    }
                    catch
                    {

                    }

                }
                foreach (DataRow row1 in result1)
                {
                    N[1] = row1["tnode_id"].ToString();
                    //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row1["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row1["tsponsor_id"].ToString() + "-" + row1["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row1["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row1["ttleftpv"].ToString() + "<br>RIGHT : " + row1["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row1["ttleftchild"].ToString() + "<br>Right : " + row1["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row1["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row1["udate"].ToString() + "</td></tr></table>";
                    string data = "<table class='table table-border'><tr><td>Name : " + row1["tnodename"].ToString() + "<br>Current Rank : " + row1["Ranks"].ToString() + "<br>Sponsor : " + row1["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row1["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row1["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row1["udate"].ToString() + "</td></tr><tr><td>Network Points,  LEFT : " + row1["ttleftpv"].ToString() + ", RIGHT : " + row1["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row1["leftleg"].ToString() + ", Right : " + row1["rightleg"].ToString() + "</table>";
                    Trees.span2 = "<img src=\"" + img(row1["Ranks"].ToString()) + "\">";
                    Trees.span2id = row1["tnode_id"].ToString();
                }


                DataRow[] result2 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[0], c));
                if ((result2.Count()) == 0 || result2 == null)
                {
                    Trees.span3 = "<img src=\"" + im + "\"> ";
                    Trees.span3id = "Create ID";
                    try
                    {
                        if (N[0].ToString().Length > 4)
                        {
                            Trees.span3 = "<img src=\"" + im + "\"> ";
                            Trees.span3id = "JOIN NOW";
                        }
                    }
                    catch
                    {
                    }
                }
                foreach (DataRow row2 in result2)
                {
                    N[2] = row2["tnode_id"].ToString();
                    //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row2["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row2["tsponsor_id"].ToString() + "-" + row2["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row2["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row2["ttleftpv"].ToString() + "<br>RIGHT : " + row2["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row2["ttleftchild"].ToString() + "<br>Right : " + row2["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row2["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row2["udate"].ToString() + "</td></tr></table>";
                    string data = "<table class='table table-border'><tr><td>Name : " + row2["tnodename"].ToString() + "<br>Current Rank : " + row2["Ranks"].ToString() + "<br>Sponsor : " + row2["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row2["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row2["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row2["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row2["ttleftpv"].ToString() + ", RIGHT : " + row2["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row2["leftleg"].ToString() + ", Right : " + row2["rightleg"].ToString() + "</table>";
                    Trees.span3 = "<img src=\"" + img(row2["Ranks"].ToString()) + "\"";
                    Trees.span3id = row2["tnode_id"].ToString();
                }


                DataRow[] result3 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[1], b));
                if ((result3.Count()) == 0 || result3 == null)
                {
                    Trees.span4 = "<img src=\"" + im + "\"> ";
                    Trees.span4id = "Create ID";
                    try
                    {


                        if (N[1].ToString().Length > 4)
                        {
                            Trees.span4 = "<img src=\"" + im + "\"> ";
                            Trees.span4id = "JOIN NOW";
                        }
                    }
                    catch
                    {

                    }

                }
                foreach (DataRow row4 in result3)
                {
                    N[3] = row4["tnode_id"].ToString();
                    //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row4["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row4["tsponsor_id"].ToString() + "-" + row4["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row4["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row4["ttleftpv"].ToString() + "<br>RIGHT : " + row4["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row4["ttleftchild"].ToString() + "<br>Right : " + row4["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row4["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row4["udate"].ToString() + "</td></tr></table>";
                    string data = "<table class='table table-border'><tr><td>Name : " + row4["tnodename"].ToString() + "<br>Current Rank : " + row4["Ranks"].ToString() + "<br>Sponsor : " + row4["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row4["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row4["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row4["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row4["ttleftpv"].ToString() + ", RIGHT : " + row4["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row4["leftleg"].ToString() + ", Right : " + row4["rightleg"].ToString() + "</table>";
                    Trees.span4 = "<img src=\"" + img(row4["Ranks"].ToString()) + "\"";
                    Trees.span4id = row4["tnode_id"].ToString();
                }

                DataRow[] result4 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[1], c));
                if ((result4.Count()) == 0 || result4 == null)
                {
                    Trees.span5 = "<img src=\"" + im + "\"> ";
                    Trees.span5id = "Create ID";
                    try
                    {

                        if (N[1].ToString().Length > 4)
                        {
                            Trees.span5 = "<img src=\"" + im + "\"> ";
                            Trees.span5id = "JOIN NOW";
                        }
                    }
                    catch
                    {

                    }
                }
                foreach (DataRow row5 in result4)
                {
                    N[4] = row5["tnode_id"].ToString();
                    //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row5["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row5["tsponsor_id"].ToString() + "-" + row5["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row5["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row5["ttleftpv"].ToString() + "<br>RIGHT : " + row5["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row5["ttleftchild"].ToString() + "<br>Right : " + row5["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row5["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row5["udate"].ToString() + "</td></tr></table>";
                    string data = "<table class='table table-border'><tr><td>Name : " + row5["tnodename"].ToString() + "<br>Current Rank : " + row5["Ranks"].ToString() + "<br>Sponsor : " + row5["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row5["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row5["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row5["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row5["ttleftpv"].ToString() + ", RIGHT : " + row5["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row5["leftleg"].ToString() + ", Right : " + row5["rightleg"].ToString() + "</table>";
                    Trees.span5 = "<img src=\"" + img(row5["Ranks"].ToString()) + "\" ";
                    Trees.span5id = row5["tnode_id"].ToString();
                }

                DataRow[] result5 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[2], b));
                if ((result5.Count()) == 0 || result5 == null)
                {
                    Trees.span6 = "<img src=\"" + im + "\"> ";
                    Trees.span6id = "Create ID";
                    try
                    {
                        if (N[2] != null)
                        {
                            if (N[2].ToString().Length > 4)
                            {
                                Trees.span6 = "<img src=\"" + im + "\"> ";
                                Trees.span6id = "JOIN NOW";
                            }
                        }
                        else
                        {
                            Trees.span6 = "<img src=\"" + im + "\"> ";
                            Trees.span6id = "Create ID";
                        }
                    }
                    catch
                    {
                        Trees.span6 = "<img src=\"" + im + "\"> ";
                        Trees.span6id = "Create ID";
                    }
                }
                foreach (DataRow row6 in result5)
                {
                    N[5] = row6["tnode_id"].ToString();
                    //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row6["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row6["tsponsor_id"].ToString() + "-" + row6["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row6["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row6["ttleftpv"].ToString() + "<br>RIGHT : " + row6["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row6["ttleftchild"].ToString() + "<br>Right : " + row6["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row6["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row6["udate"].ToString() + "</td></tr></table>";
                    string data = "<table class='table table-border'><tr><td>Name : " + row6["tnodename"].ToString() + "<br>Current Rank : " + row6["Ranks"].ToString() + "<br>Sponsor : " + row6["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row6["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row6["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row6["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row6["ttleftpv"].ToString() + ", RIGHT : " + row6["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row6["leftleg"].ToString() + ", Right : " + row6["rightleg"].ToString() + "</table>";
                    Trees.span6 = "<img src=\"" + img(row6["Ranks"].ToString()) + "\"  ";
                    Trees.span6id = row6["tnode_id"].ToString();
                }

                DataRow[] result6 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[2], c));
                if ((result6.Count()) == 0 || result6 == null)
                {
                    Trees.span7 = "<img src=\"" + im + "\"> ";
                    Trees.span7id = "Create ID";
                    try
                    {
                        if (N[2] != null)
                        {
                            if (N[2].ToString().Length > 4)
                            {
                                Trees.span7 = "<img src=\"" + im + "\"> ";
                                Trees.span7id = "JOIN NOW";
                            }
                        }
                        else
                        {
                            Trees.span7 = "<img src=\"" + im + "\"> ";
                            Trees.span7id = "Create ID";
                        }
                    }
                    catch
                    {
                        Trees.span7 = "<img src=\"" + im + "\"> ";
                        Trees.span7id = "Create ID";
                    }
                }
                foreach (DataRow row7 in result6)
                {
                    N[6] = row7["tnode_id"].ToString();
                    //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row7["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row7["tsponsor_id"].ToString() + "-" + row7["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row7["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row7["ttleftpv"].ToString() + "<br>RIGHT : " + row7["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row7["ttleftchild"].ToString() + "<br>Right : " + row7["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row7["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row7["udate"].ToString() + "</td></tr></table>";
                    string data = "<table class='table table-border'><tr><td>Name : " + row7["tnodename"].ToString() + "<br>Current Rank : " + row7["Ranks"].ToString() + "<br>Sponsor : " + row7["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row7["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row7["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row7["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row7["ttleftpv"].ToString() + ", RIGHT : " + row7["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row7["leftleg"].ToString() + ", Right : " + row7["rightleg"].ToString() + "</table>";
                    Trees.span7 = "<img src=\"" + img(row7["Ranks"].ToString()) + "\"  ";
                    Trees.span7id = row7["tnode_id"].ToString();
                }

                DataRow[] result7 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[3], b));
                if ((result7.Count()) == 0 || result7 == null)
                {
                    Trees.span8 = "<img src=\"" + im + "\"> ";
                    Trees.span8id = "Create ID";
                    try
                    {

                        if (N[3] != null)
                        {
                            if (N[3].ToString().Length > 4)
                            {
                                Trees.span8 = "<img src=\"" + im + "\"> ";
                                Trees.span8id = "JOIN NOW";
                            }
                        }
                        else
                        {
                            Trees.span8 = "<img src=\"" + im + "\"> ";
                            Trees.span8id = "Create ID";
                        }
                    }
                    catch
                    {
                        Trees.span8 = "<img src=\"" + im + "\"> ";
                        Trees.span8id = "Create ID";
                    }
                }
                foreach (DataRow row8 in result7)
                {
                    N[7] = row8["tnode_id"].ToString();
                    //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row8["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row8["tsponsor_id"].ToString() + "-" + row8["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row8["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row8["ttleftpv"].ToString() + "<br>RIGHT : " + row8["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row8["ttleftchild"].ToString() + "<br>Right : " + row8["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row8["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row8["udate"].ToString() + "</td></tr></table>";
                    string data = "<table class='table table-border'><tr><td>Name : " + row8["tnodename"].ToString() + "<br>Current Rank : " + row8["Ranks"].ToString() + "<br>Sponsor : " + row8["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row8["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row8["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row8["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row8["ttleftpv"].ToString() + ", RIGHT : " + row8["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row8["leftleg"].ToString() + ", Right : " + row8["rightleg"].ToString() + "</table>";
                    Trees.span8 = "<img src=\"" + img(row8["Ranks"].ToString()) + "\" ";
                    Trees.span8id = row8["tnode_id"].ToString();
                }

                DataRow[] result8 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[3], c));
                if ((result8.Count()) == 0 || result8 == null)
                {
                    Trees.span9 = "<img src=\"" + im + "\"> ";
                    Trees.span9id = "Create ID";
                    try
                    {
                        if (N[3] != null)
                        {

                            if (N[3].ToString().Length > 4)
                            {
                                Trees.span9 = "<img src=\"" + im + "\"> ";
                                Trees.span9id = "JOIN NOW";
                            }
                        }
                        else
                        {
                            Trees.span9 = "<img src=\"" + im + "\"> ";
                            Trees.span9id = "Create ID";
                        }
                    }
                    catch
                    {

                    }
                }
                foreach (DataRow row9 in result8)
                {
                    N[8] = row9["tnode_id"].ToString();
                    //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row9["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row9["tsponsor_id"].ToString() + "-" + row9["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row9["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row9["ttleftpv"].ToString() + "<br>RIGHT : " + row9["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row9["ttleftchild"].ToString() + "<br>Right : " + row9["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row9["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row9["udate"].ToString() + "</td></tr></table>";
                    string data = "<table class='table table-border'><tr><td>Name : " + row9["tnodename"].ToString() + "<br>Current Rank : " + row9["Ranks"].ToString() + "<br>Sponsor : " + row9["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row9["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row9["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row9["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row9["ttleftpv"].ToString() + ", RIGHT : " + row9["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row9["leftleg"].ToString() + ", Right : " + row9["rightleg"].ToString() + "</table>";
                    Trees.span9 = "<img src=\"" + img(row9["Ranks"].ToString()) + "\" ";
                    Trees.span9id = row9["tnode_id"].ToString();
                }


                DataRow[] result9 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[4], b));
                if ((result9.Count()) == 0 || result9 == null)
                {
                    Trees.span10 = "<img src=\"" + im + "\"> ";
                    Trees.span10id = "Create ID";
                    try
                    {

                        if (N[4] != null)
                        {
                            if (N[4].ToString().Length > 4)
                            {
                                Trees.span10 = "<img src=\"" + im + "\"> ";
                                Trees.span10id = "JOIN NOW";
                            }
                        }
                        else
                        {
                            Trees.span10 = "<img src=\"" + im + "\"> ";
                            Trees.span10id = "Create ID";
                        }
                    }
                    catch
                    {

                    }
                }
                foreach (DataRow row10 in result9)
                {
                    N[9] = row10["tnode_id"].ToString();
                    //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row10["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row10["tsponsor_id"].ToString() + "-" + row10["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row10["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row10["ttleftpv"].ToString() + "<br>RIGHT : " + row10["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row10["ttleftchild"].ToString() + "<br>Right : " + row10["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row10["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row10["udate"].ToString() + "</td></tr></table>";
                    string data = "<table class='table table-border'><tr><td>Name : " + row10["tnodename"].ToString() + "<br>Current Rank : " + row10["Ranks"].ToString() + "<br>Sponsor : " + row10["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row10["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row10["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row10["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row10["ttleftpv"].ToString() + ", RIGHT : " + row10["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row10["leftleg"].ToString() + ", Right : " + row10["rightleg"].ToString() + "</table>";
                    Trees.span10 = "<img src=\"" + img(row10["Ranks"].ToString()) + "\" ";
                    Trees.span10id = row10["tnode_id"].ToString();
                }

                DataRow[] result10 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[4], c));
                if ((result10.Count()) == 0 || result10 == null)
                {
                    Trees.span11 = "<img src=\"" + im + "\"> ";
                    Trees.span11id = "Create ID";
                    try
                    {
                        if (N[4] != null)
                        {
                            if (N[4].ToString().Length > 4)
                            {
                                Trees.span11 = "<img src=\"" + im + "\"> ";
                                Trees.span11id = "JOIN NOW";
                            }
                        }
                        else
                        {
                            Trees.span11 = "<img src=\"" + im + "\"> ";
                            Trees.span11id = "Create ID";
                        }
                    }
                    catch
                    {

                    }
                }
                foreach (DataRow row11 in result10)
                {
                    N[10] = row11["tnode_id"].ToString();
                    //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row11["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row11["tsponsor_id"].ToString() + "-" + row11["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row11["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row11["ttleftpv"].ToString() + "<br>RIGHT : " + row11["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row11["ttleftchild"].ToString() + "<br>Right : " + row11["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row11["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row11["udate"].ToString() + "</td></tr></table>";
                    string data = "<table class='table table-border'><tr><td>Name : " + row11["tnodename"].ToString() + "<br>Current Rank : " + row11["Ranks"].ToString() + "<br>Sponsor : " + row11["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row11["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row11["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row11["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row11["ttleftpv"].ToString() + ", RIGHT : " + row11["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row11["leftleg"].ToString() + ", Right : " + row11["rightleg"].ToString() + "</table>";
                    Trees.span11 = "<img src=\"" + img(row11["Ranks"].ToString()) + "\" ";
                    Trees.span11id = row11["tnode_id"].ToString();
                }

                DataRow[] result11 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[5], b));
                if ((result11.Count()) == 0 || result11 == null)
                {
                    Trees.span12 = "<img src=\"" + im + "\"> ";
                    Trees.span12id = "Create ID";
                    try
                    {
                        if (N[5] != null)
                        {
                            if (N[5].ToString().Length > 4)
                            {
                                Trees.span12 = "<img src=\"" + im + "\"> ";
                                Trees.span12id = "JOIN NOW";
                            }
                        }
                        else
                        {
                            Trees.span12 = "<img src=\"" + im + "\"> ";
                            Trees.span12id = "Create ID";
                        }
                    }
                    catch
                    {

                    }
                }
                foreach (DataRow row12 in result11)
                {
                    N[11] = row12["tnode_id"].ToString();
                    //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row12["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row12["tsponsor_id"].ToString() + "-" + row12["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row12["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row12["ttleftpv"].ToString() + "<br>RIGHT : " + row12["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row12["ttleftchild"].ToString() + "<br>Right : " + row12["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row12["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row12["udate"].ToString() + "</td></tr></table>";
                    string data = "<table class='table table-border'><tr><td>Name : " + row12["tnodename"].ToString() + "<br>Current Rank : " + row12["Ranks"].ToString() + "<br>Sponsor : " + row12["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row12["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row12["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row12["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row12["ttleftpv"].ToString() + ", RIGHT : " + row12["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row12["leftleg"].ToString() + ", Right : " + row12["rightleg"].ToString() + "</table>";
                    Trees.span12 = "<img src=\"" + img(row12["Ranks"].ToString()) + "\" ";
                    Trees.span12id = row12["tnode_id"].ToString();
                }

                DataRow[] result12 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[5], c));
                if ((result12.Count()) == 0 || result12 == null)
                {
                    Trees.span13 = "<img src=\"" + im + "\"> ";
                    Trees.span13id = "Create ID";
                    try
                    {

                        if (N[5] != null)
                        {
                            if (N[5].ToString().Length > 4)
                            {
                                Trees.span13 = "<img src=\"" + im + "\"> ";
                                Trees.span13id = "JOIN NOW";
                            }
                        }
                        else
                        {
                            Trees.span13 = "<img src=\"" + im + "\"> ";
                            Trees.span13id = "Create ID";
                        }
                    }
                    catch
                    {

                    }
                }
                foreach (DataRow row13 in result12)
                {
                    N[12] = row13["tnode_id"].ToString();
                    //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row13["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row13["tsponsor_id"].ToString() + "-" + row13["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row13["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row13["ttleftpv"].ToString() + "<br>RIGHT : " + row13["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row13["ttleftchild"].ToString() + "<br>Right : " + row13["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row13["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row13["udate"].ToString() + "</td></tr></table>";
                    string data = "<table class='table table-border'><tr><td>Name : " + row13["tnodename"].ToString() + "<br>Current Rank : " + row13["Ranks"].ToString() + "<br>Sponsor : " + row13["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row13["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row13["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row13["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row13["ttleftpv"].ToString() + ", RIGHT : " + row13["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row13["leftleg"].ToString() + ", Right : " + row13["rightleg"].ToString() + "</table>";
                    Trees.span13 = "<img src=\"" + img(row13["Ranks"].ToString()) + "\" ";
                    Trees.span13id = row13["tnode_id"].ToString();
                }

                DataRow[] result13 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[6], b));
                if ((result13.Count()) == 0 || result13 == null)
                {
                    Trees.span14 = "<img src=\"" + im + "\"> ";
                    Trees.span14id = "Create ID";
                    try
                    {
                        if (N[6] != null)
                        {

                            if (N[6].ToString().Length > 4)
                            {
                                Trees.span14 = "<img src=\"" + im + "\"> ";
                                Trees.span14id = "JOIN NOW";
                            }
                        }
                        else
                        {
                            Trees.span14 = "<img src=\"" + im + "\"> ";
                            Trees.span14id = "Create ID";
                        }
                    }
                    catch
                    {

                    }
                }
                foreach (DataRow row14 in result13)
                {
                    N[9] = row14["tnode_id"].ToString();
                    //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row14["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row14["tsponsor_id"].ToString() + "-" + row14["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row14["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row14["ttleftpv"].ToString() + "<br>RIGHT : " + row14["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row14["ttleftchild"].ToString() + "<br>Right : " + row14["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row14["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row14["udate"].ToString() + "</td></tr></table>";
                    string data = "<table class='table table-border'><tr><td>Name : " + row14["tnodename"].ToString() + "<br>Current Rank : " + row14["Ranks"].ToString() + "<br>Sponsor : " + row14["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row14["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row14["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date : " + row14["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row14["ttleftpv"].ToString() + ", RIGHT : " + row14["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row14["leftleg"].ToString() + ", Right : " + row14["rightleg"].ToString() + "</table>";
                    Trees.span14 = "<img src=\"" + img(row14["Ranks"].ToString()) + "\" ";
                    Trees.span14id = row14["tnode_id"].ToString();
                }

                DataRow[] result14 = dataSet.Tables[0].Select(string.Format("tparent_id='{0}' and tparent_leg like'{1}'", N[6], c));
                if ((result14.Count()) == 0 || result14 == null)
                {
                    Trees.span15 = "<img src=\"" + im + "\"> ";
                    Trees.span15id = "Create ID";
                    try
                    {
                        if (N[6] != null)
                        {

                            if (N[6].ToString().Length > 4)
                            {
                                Trees.span15 = "<img src=\"" + im + "\"> ";
                                Trees.span15id = "JOIN NOW";
                            }
                        }
                        else
                        {
                            Trees.span15 = "<img src=\"" + im + "\"> ";
                            Trees.span15id = "Create ID";
                        }
                    }
                    catch
                    {

                    }
                }
                foreach (DataRow row15 in result14)
                {
                    N[10] = row15["tnode_id"].ToString();
                    //string data = "<table class='table table-bordered table-condensed'><tr><td class='success'> Name </td> <td>  " + row15["tnodename"].ToString() + "</td></tr> <tr><td class='success'> Sponsor :</td> <td> " + row15["tsponsor_id"].ToString() + "-" + row15["tsponsorname"].ToString() + "</td></tr><tr><td class='success'> JoiningDate </td> <td> " + row15["tdatetime"].ToString() + "</td></tr><tr><td class='success'> Network PV </td> <td> LEFT : " + row15["ttleftpv"].ToString() + "<br>RIGHT : " + row15["ttrightpv"].ToString() + " </td></tr><tr><td class='success'> NetworkCount</td> <td> Left :" + row15["ttleftchild"].ToString() + "<br>Right : " + row15["ttrightchild"].ToString() + "</td></tr><tr><td class='success'> Package </td> <td> $  " + row15["package"].ToString() + "</td></tr> <tr><td class='success'> Activation Date : " + row15["udate"].ToString() + "</td></tr></table>";
                    string data = "<table class='table table-border'><tr><td>Name : " + row15["tnodename"].ToString() + "<br>Current Rank : " + row15["Ranks"].ToString() + "<br>Sponsor : " + row15["tsponsor_id"].ToString() + "</td></tr><tr><td> $   " + row15["package"].ToString() + "</td></tr><tr><td>Joining Date : " + row15["tdatetime"].ToString() + "</td></tr><tr><td>Activation Date " + row15["udate"].ToString() + "</td></tr><tr><td>Network points,  LEFT : " + row15["ttleftpv"].ToString() + ", RIGHT : " + row15["ttrightpv"].ToString() + " </td></tr><tr><td>Network Count, Left :" + row15["leftleg"].ToString() + ", Right : " + row15["rightleg"].ToString() + "</table>";
                    Trees.span15 = "<img src=\"" + img(row15["Ranks"].ToString()) + "\" ";
                    Trees.span15id = row15["tnode_id"].ToString();
                }

            }
            return Trees;
        }

        public string img(string status)
            {
                if (status == "0")
                {
                    return "/../image/Associate.png";
                }
                else if (status == "1")
                {
                    return "/../image/Bronz.png";
                }
                else if (status == "2")
                {
                    return "/../image/Silver.png";
                }
                else if (status == "3")
                {
                    return "/../image/Gold.png";
                }
                else if (status == "4")
                {
                    return "/../image/Pearl.png";
                }
                else if (status == "5")
                {
                    return "/../image/Topaz.png";
                }
                 else if (status == "6")
                 {
                     return "/../image/Diamond.png";
                 }
                 else
                {
                    return "/../image/Empty.png";
                }
            }
        }
}

