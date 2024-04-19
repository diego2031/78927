using System;
using System.ServiceModel;

namespace icalculadora {
    [ServiceContract]
    public interface iCalculadora {
        [OperationContract]
        int F(int a);
        int C(int b);
    }
}