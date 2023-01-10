using System.Security;

namespace Shared.ValueObjects;

public class Email
{
    #region Constructors

    

    #endregion
    
    #region Properties

    public string Address { get; private set; } = string.Empty;

    public Verification Verification { get; private set; } = new();

    #endregion

    #region Methods



    #endregion

    #region OverLoads



    #endregion
}