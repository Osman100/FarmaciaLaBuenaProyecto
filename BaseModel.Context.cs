﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace La_Buena_Farmacia
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class FARMACIA_BUENA__SALUDEntities2 : DbContext
    {
        public FARMACIA_BUENA__SALUDEntities2()
            : base("name=FARMACIA_BUENA__SALUDEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Compra> Compra { get; set; }
        public virtual DbSet<DetalleCompra> DetalleCompra { get; set; }
        public virtual DbSet<DetalleVenta> DetalleVenta { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TarjetaCredito> TarjetaCredito { get; set; }
        public virtual DbSet<Venta> Venta { get; set; }
        public virtual DbSet<VistaDetalleVenta> VistaDetalleVenta { get; set; }
        public virtual DbSet<VistaEmpleados> VistaEmpleados { get; set; }
        public virtual DbSet<VistaProductos> VistaProductos { get; set; }
        public virtual DbSet<VistaDetalleCompra> VistaDetalleCompra { get; set; }
        public virtual DbSet<VistaVenta> VistaVenta { get; set; }
        public virtual DbSet<VistaProductos1> VistaProductos1 { get; set; }
        public virtual DbSet<VistaCompra> VistaCompra { get; set; }
        public virtual DbSet<VistaDetalleCompra2> VistaDetalleCompra2 { get; set; }
        public virtual DbSet<VistaDetalleVenta3> VistaDetalleVenta3 { get; set; }
        public virtual DbSet<VistaVenta3> VistaVenta3 { get; set; }
        public virtual DbSet<VistaDetalleVenta4> VistaDetalleVenta4 { get; set; }
        public virtual DbSet<VistaTarjetas> VistaTarjetas { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<VistaProductosMasVendidos> VistaProductosMasVendidos { get; set; }
    
        public virtual int decreaseStock(Nullable<int> idProducto, Nullable<int> cantidad)
        {
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("idProducto", idProducto) :
                new ObjectParameter("idProducto", typeof(int));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("cantidad", cantidad) :
                new ObjectParameter("cantidad", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("decreaseStock", idProductoParameter, cantidadParameter);
        }
    
        public virtual int increaseStock(Nullable<int> idProducto, Nullable<int> cantidad)
        {
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("idProducto", idProducto) :
                new ObjectParameter("idProducto", typeof(int));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("cantidad", cantidad) :
                new ObjectParameter("cantidad", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("increaseStock", idProductoParameter, cantidadParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int AgregarCompraDetalleCompra(Nullable<int> idProveedorParam, string tipoCompraParam, Nullable<System.DateTime> fechaCompraParam, Nullable<decimal> totalCompraParam, Nullable<int> idProductoParam, Nullable<int> cantidadProductoParam, Nullable<decimal> subtotalParam)
        {
            var idProveedorParamParameter = idProveedorParam.HasValue ?
                new ObjectParameter("idProveedorParam", idProveedorParam) :
                new ObjectParameter("idProveedorParam", typeof(int));
    
            var tipoCompraParamParameter = tipoCompraParam != null ?
                new ObjectParameter("tipoCompraParam", tipoCompraParam) :
                new ObjectParameter("tipoCompraParam", typeof(string));
    
            var fechaCompraParamParameter = fechaCompraParam.HasValue ?
                new ObjectParameter("fechaCompraParam", fechaCompraParam) :
                new ObjectParameter("fechaCompraParam", typeof(System.DateTime));
    
            var totalCompraParamParameter = totalCompraParam.HasValue ?
                new ObjectParameter("totalCompraParam", totalCompraParam) :
                new ObjectParameter("totalCompraParam", typeof(decimal));
    
            var idProductoParamParameter = idProductoParam.HasValue ?
                new ObjectParameter("idProductoParam", idProductoParam) :
                new ObjectParameter("idProductoParam", typeof(int));
    
            var cantidadProductoParamParameter = cantidadProductoParam.HasValue ?
                new ObjectParameter("cantidadProductoParam", cantidadProductoParam) :
                new ObjectParameter("cantidadProductoParam", typeof(int));
    
            var subtotalParamParameter = subtotalParam.HasValue ?
                new ObjectParameter("subtotalParam", subtotalParam) :
                new ObjectParameter("subtotalParam", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AgregarCompraDetalleCompra", idProveedorParamParameter, tipoCompraParamParameter, fechaCompraParamParameter, totalCompraParamParameter, idProductoParamParameter, cantidadProductoParamParameter, subtotalParamParameter);
        }
    
        public virtual int CompraYDetalle(Nullable<int> idProveedorParam, string tipoCompraParam, Nullable<System.DateTime> fechaCompraParam, Nullable<decimal> totalCompraParam, Nullable<int> idProductoParam, Nullable<int> cantidadProductoParam, Nullable<decimal> subtotalParam)
        {
            var idProveedorParamParameter = idProveedorParam.HasValue ?
                new ObjectParameter("idProveedorParam", idProveedorParam) :
                new ObjectParameter("idProveedorParam", typeof(int));
    
            var tipoCompraParamParameter = tipoCompraParam != null ?
                new ObjectParameter("tipoCompraParam", tipoCompraParam) :
                new ObjectParameter("tipoCompraParam", typeof(string));
    
            var fechaCompraParamParameter = fechaCompraParam.HasValue ?
                new ObjectParameter("fechaCompraParam", fechaCompraParam) :
                new ObjectParameter("fechaCompraParam", typeof(System.DateTime));
    
            var totalCompraParamParameter = totalCompraParam.HasValue ?
                new ObjectParameter("totalCompraParam", totalCompraParam) :
                new ObjectParameter("totalCompraParam", typeof(decimal));
    
            var idProductoParamParameter = idProductoParam.HasValue ?
                new ObjectParameter("idProductoParam", idProductoParam) :
                new ObjectParameter("idProductoParam", typeof(int));
    
            var cantidadProductoParamParameter = cantidadProductoParam.HasValue ?
                new ObjectParameter("cantidadProductoParam", cantidadProductoParam) :
                new ObjectParameter("cantidadProductoParam", typeof(int));
    
            var subtotalParamParameter = subtotalParam.HasValue ?
                new ObjectParameter("subtotalParam", subtotalParam) :
                new ObjectParameter("subtotalParam", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CompraYDetalle", idProveedorParamParameter, tipoCompraParamParameter, fechaCompraParamParameter, totalCompraParamParameter, idProductoParamParameter, cantidadProductoParamParameter, subtotalParamParameter);
        }
    }
}
