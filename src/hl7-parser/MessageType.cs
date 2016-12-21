using System;

namespace hl7_parser
{

    public class MessageType
    {
        public MessageType(string value, char[] encodingCharacters)
        {
            string[] values = value.Split(encodingCharacters);
            AddValue((x) => MessageCode = (MessageCode)Enum.Parse(typeof(MessageCode), x, true), values, 0);
            AddValue((x) => TriggerEvent = (TriggerEvent)Enum.Parse(typeof(TriggerEvent), x, true), values, 1);
            AddValue((x) => MessageStructure = x, values, 2);
        }

        private void AddValue(Action<string> addValue, string[] values, int index)
        {
            if (values.Length > index)
                addValue(values[index]);
        }

        public MessageCode MessageCode { get; set; }
        public TriggerEvent TriggerEvent { get; set; }
        public string MessageStructure { get; set; }

    }

    public enum TriggerEvent
    {
        ///<summary>
        ///ADT/ACK - Admit / visit notification
        ///</summary>	
        A01,
        ///<summary>
        ///ADT/ACK - Discharge/end visit
        ///</summary>	
        A03,
        ///<summary>
        ///ADT/ACK - Pre-admit a patient
        ///</summary>	
        A05,
        ///<summary>
        ///ADT/ACK - Change an inpatient to an outpatient
        ///</summary>	
        A07,
        ///<summary>
        ///ADT/ACK - Patient departing - tracking
        ///</summary>	
        A09,
        ///<summary>
        ///ADT/ACK - Cancel admit/visit notification
        ///</summary>	
        A11,
        ///<summary>
        ///ADT/ACK - Cancel discharge/end visit
        ///</summary>	
        A13,
        ///<summary>
        ///ADT/ACK - Pending transfer
        ///</summary>	
        A15,
        ///<summary>
        ///ADT/ACK - Swap patients
        ///</summary>	
        A17,
        ///<summary>
        ///QRY/ADR - Patient query
        ///</summary>	
        A19,
        ///<summary>
        ///ADT/ACK - Patient goes on a leave of absence
        ///</summary>	
        A21,
        ///<summary>
        ///ADT/ACK - Delete a patient record
        ///</summary>	
        A23,
        ///<summary>
        ///ADT/ACK - Cancel pending discharge
        ///</summary>	
        A25,
        ///<summary>
        ///ADT/ACK - Cancel pending admit
        ///</summary>	
        A27,
        ///<summary>
        ///ADT/ACK - Delete person information
        ///</summary>	
        A29,
        ///<summary>
        ///ADT/ACK - Update person information
        ///</summary>	
        A31,
        ///<summary>
        ///ADT/ACK - Cancel patient departing - tracking
        ///</summary>	
        A33,
        ///<summary>
        ///ADT/ACK - Merge patient information - account number only
        ///</summary>	
        A35,
        ///<summary>
        ///ADT/ACK - Unlink patient information
        ///</summary>	
        A37,
        ///<summary>
        ///ADT/ACK - Merge person - external ID
        ///</summary>	
        A39,
        ///<summary>
        ///ADT/ACK - Merge account - patient account number
        ///</summary>	
        A41,
        ///<summary>
        ///ADT/ACK - Move patient information - internal ID
        ///</summary>	
        A43,
        ///<summary>
        ///ADT/ACK - Move visit information - visit number
        ///</summary>	
        A45,
        ///<summary>
        ///ADT/ACK - Change internal ID
        ///</summary>	
        A47,
        ///<summary>
        ///ADT/ACK - Change patient account number
        ///</summary>	
        A49,
        ///<summary>
        ///ADT/ACK - Change alternate visit ID
        ///</summary>	
        A51,
        ///<summary>
        ///CRM - Cancel a patient registration on clinical trial (for clerical mistakes only)
        ///</summary>	
        C02,
        ///<summary>
        ///CRM - Patient has gone off a clinical trial
        ///</summary>	
        C04,
        ///<summary>
        ///CRM - Cancel patient entering a phase (clerical mistake)
        ///</summary>	
        C06,
        ///<summary>
        ///CRM - Patient has gone off phase of clinical trial
        ///</summary>	
        C08,
        ///<summary>
        ///CSU - Patient completes the clinical trial
        ///</summary>	
        C10,
        ///<summary>
        ///CSU - Update/correction of patient order/result information
        ///</summary>	
        C12,
        ///<summary>
        ///PGL/ACK - Patient goal
        ///</summary>	
        G01,
        ///<summary>
        ///RQI/RPL - Request/receipt of patient selection display list
        ///</summary>	
        I02,
        ///<summary>
        ///RQD/RPI - Request for patient demographic data
        ///</summary>	
        I04,
        ///<summary>
        ///RQC/RCL - Request/receipt of clinical data listing
        ///</summary>	
        I06,
        ///<summary>
        ///RQA/RPA - Request for treatment authorization information
        ///</summary>	
        I08,
        ///<summary>
        ///RQA/RPA - Request for resubmission of an authorization
        ///</summary>	
        I10,
        ///<summary>
        ///REF/RRI - Patient referral
        ///</summary>	
        I12,
        ///<summary>
        ///REF/RRI - Cancel patient referral
        ///</summary>	
        I14,
        ///<summary>
        ///MFN/MFK - Master file not otherwise specified (for backward compatibility only)
        ///</summary>	
        M01,
        ///<summary>
        ///MFN/MFK - Master file - Test/Observation (for backward compatibility only)
        ///</summary>	
        M03,
        ///<summary>
        ///MFN/MFK - Master files charge description
        ///</summary>	
        M04,
        ///<summary>
        ///MFN/MFK - Clinical study with phases and schedules master file
        ///</summary>	
        M06,
        ///<summary>
        ///MFN/MFK - Test/observation (Numeric) master file
        ///</summary>	
        M08,
        ///<summary>
        ///MFN/MFK - Test /observation batteries master file
        ///</summary>	
        M10,
        ///<summary>
        ///ORM - Order message (also RDE, RDS, RGV, RAS)
        ///</summary>	
        O01,
        ///<summary>
        ///BAR/ACK - Add patient accounts
        ///</summary>	
        P01,
        ///<summary>
        ///DFT/ACK - Post detail financial transaction
        ///</summary>	
        P03,
        ///<summary>
        ///BAR/ACK - Update account
        ///</summary>	
        P05,
        ///<summary>
        ///PEX - Unsolicited initial individual product experience report
        ///</summary>	
        P07,
        ///<summary>
        ///SUR - Summary product experience report
        ///</summary>	
        P09,
        ///<summary>
        ///PPR - PC/ Problem Update
        ///</summary>	
        PC2,
        ///<summary>
        ///PRQ - PC/ Problem Query
        ///</summary>	
        PC4,
        ///<summary>
        ///PGL - PC/ Goal Add
        ///</summary>	
        PC6,
        ///<summary>
        ///PGL - PC/ Goal Delete
        ///</summary>	
        PC8,
        ///<summary>
        ///PGR - PC/ Goal Response
        ///</summary>	
        PCA,
        ///<summary>
        ///PPP - PC/ Pathway (Problem-Oriented) Update
        ///</summary>	
        PCC,
        ///<summary>
        ///PTQ - PC/ Pathway (Problem-Oriented) Query
        ///</summary>	
        PCE,
        ///<summary>
        ///PPG - PC/ Pathway (Goal-Oriented) Add
        ///</summary>	
        PCG,
        ///<summary>
        ///PPG - PC/ Pathway (Goal-Oriented) Delete
        ///</summary>	
        PCJ,
        ///<summary>
        ///PTV - PC/ Pathway (Goal-Oriented) Query Response
        ///</summary>	
        PCL,
        ///<summary>
        ///QRY/QCK - Query sent for deferred response
        ///</summary>	
        Q02,
        ///<summary>
        ///UDM/ACK - Unsolicited display update message
        ///</summary>	
        Q05,
        ///<summary>
        ///ORU/ACK - Unsolicited transmission of an observation message
        ///</summary>	
        R01,
        ///<summary>
        ///QRY/DSR Display-oriented results, query/unsol. update (for backward compatibility only)
        ///</summary>	
        R03,
        ///<summary>
        ///QRY/DSR-query for display results
        ///</summary>	
        R05,
        ///<summary>
        ///RAR - Pharmacy administration information query response
        ///</summary>	
        RAR,
        ///<summary>
        ///RER - Pharmacy encoded order information query response
        ///</summary>	
        RER,
        ///<summary>
        ///ROR - Pharmacy prescription order query response
        ///</summary>	
        ROR,
        ///<summary>
        ///SRM/SRR - Request appointment rescheduling
        ///</summary>	
        S02,
        ///<summary>
        ///SRM/SRR - Request appointment cancellation
        ///</summary>	
        S04,
        ///<summary>
        ///SRM/SRR - Request appointment deletion
        ///</summary>	
        S06,
        ///<summary>
        ///SRM/SRR - Request modification of service/resource on appointment
        ///</summary>	
        S08,
        ///<summary>
        ///SRM/SRR - Request discontinuation of service/resource on appointment
        ///</summary>	
        S10,
        ///<summary>
        ///SIU/ACK - Notification of new appointment booking
        ///</summary>	
        S12,
        ///<summary>
        ///SIU/ACK - Notification of appointment modification
        ///</summary>	
        S14,
        ///<summary>
        ///SIU/ACK - Notification of appointment discontinuation
        ///</summary>	
        S16,
        ///<summary>
        ///SIU/ACK - Notification of addition of service/resource on appointment
        ///</summary>	
        S18,
        ///<summary>
        ///SIU/ACK - Notification of cancellation of service/resource on appointment
        ///</summary>	
        S20,
        ///<summary>
        ///SIU/ACK - Notification of deletion of service/resource on appointment
        ///</summary>	
        S22,
        ///<summary>
        ///SIU/ACK - Notification of opened (unblocked) schedule time slot(s)
        ///</summary>	
        S24,
        ///<summary>
        ///Notification that patient did not show up for schedule appointment
        ///</summary>	
        S26,
        ///<summary>
        ///MDM/ACK - Original document notification and content
        ///</summary>	
        T02,
        ///<summary>
        ///MDM/ACK - Document status change notification and content
        ///</summary>	
        T04,
        ///<summary>
        ///MDM/ACK - Document addendum notification and content
        ///</summary>	
        T06,
        ///<summary>
        ///MDM/ACK - Document edit notification and content
        ///</summary>	
        T08,
        ///<summary>
        ///MDM/ACK - Document replacement notification and content
        ///</summary>	
        T10,
        ///<summary>
        ///QRY/DOC - Document query
        ///</summary>	
        T12,
        ///<summary>
        ///VXX - Response to vaccination query returning multiple PID matches
        ///</summary>	
        V02,
        ///<summary>
        ///VXU - Unsolicited vaccination record update
        ///</summary>	
        V04,
        ///<summary>
        ///QRF - Waveform result, response to query
        ///</summary>	
        W02,
        ///<summary>
        ///PEX - Product experience
        ///</summary>	
        X01,

    }

    public enum MessageCode
    {
        ///<summary>
        ///General acknowledgment message
        ///</summary>	
        ACK,
        ///<summary>
        ///ADT message
        ///</summary>	
        ADT,
        ///<summary>
        ///Add/change billing account
        ///</summary>	
        BAR,
        ///<summary>
        ///Detail financial transaction
        ///</summary>	
        DFT,
        ///<summary>
        ///Enhanced display response
        ///</summary>	
        EDR,
        ///<summary>
        ///Event replay query
        ///</summary>	
        ERQ,
        ///<summary>
        ///Delayed acknowledgment
        ///</summary>	
        MCF,
        ///<summary>
        ///Master files notification
        ///</summary>	
        MFN,
        ///<summary>
        ///Master files delayed application acknowledgement
        ///</summary>	
        MFD,
        ///<summary>
        ///Master files query response
        ///</summary>	
        MFR,
        ///<summary>
        ///Order message
        ///</summary>	
        ORM,
        ///<summary>
        ///Observ result/unsolicited
        ///</summary>	
        ORU,
        ///<summary>
        ///Order status response
        ///</summary>	
        OSR,
        ///<summary>
        ///Product experience
        ///</summary>	
        PEX,
        ///<summary>
        ///Patient goal response
        ///</summary>	
        PGR,
        ///<summary>
        ///Patient Insurance Information
        ///</summary>	
        PII, //TODO: prüfen
        ///<summary>
        ///Patient pathway (problem-oriented)
        ///</summary>	
        PPP,
        ///<summary>
        ///Patient pathway (goal oriented)
        ///</summary>	
        PPT,
        ///<summary>
        ///Patient care problem query
        ///</summary>	
        PRQ,
        ///<summary>
        ///Patient pathway (problem-oriented) query
        ///</summary>	
        PTQ,
        ///<summary>
        ///Patient pathway (goal-oriented) query
        ///</summary>	
        PTU,
        ///<summary>
        ///Patient information
        ///</summary>	
        PIN,
        ///<summary>
        ///Pharmacy administration message
        ///</summary>	
        RAS,
        ///<summary>
        ///Return clinical list
        ///</summary>	
        RCL,
        ///<summary>
        ///Pharmacy dispense information
        ///</summary>	
        RDR,
        ///<summary>
        ///Pharmacy give message
        ///</summary>	
        RGV,
        ///<summary>
        ///Patient referral
        ///</summary>	
        REF,
        ///<summary>
        ///Request patient demographics
        ///</summary>	
        ROD,
        ///<summary>
        ///Return patient authorization
        ///</summary>	
        RPA,
        ///<summary>
        ///Return patient display list
        ///</summary>	
        RPL,
        ///<summary>
        ///Request patient authorization
        ///</summary>	
        RQA,
        ///<summary>
        ///Request patient information
        ///</summary>	
        RQI,
        ///<summary>
        ///Pharmacy administration acknowledgment
        ///</summary>	
        RRA,
        ///<summary>
        ///Pharmacy encoded order acknowledgment
        ///</summary>	
        RRE,
        ///<summary>
        ///Return patient referral
        ///</summary>	
        RRI,
        ///<summary>
        ///Stored procedure request
        ///</summary>	
        SPQ,
        ///<summary>
        ///Schedule query response
        ///</summary>	
        SQR,
        ///<summary>
        ///Schedule request
        ///</summary>	
        SRM,
        ///<summary>
        ///Summary product experience report
        ///</summary>	
        SUR,
        ///<summary>
        ///Unsolicited display message
        ///</summary>	
        UDM,
        ///<summary>
        ///Query for vaccination record
        ///</summary>	
        VXQ,
        ///<summary>
        ///Vaccination query record response
        ///</summary>	
        VXR,

    }
}
