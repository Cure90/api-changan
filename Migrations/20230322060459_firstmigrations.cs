using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace back_end.Migrations
{
    /// <inheritdoc />
    public partial class firstmigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agencies",
                columns: table => new
                {
                    agencyId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    agency_name = table.Column<string>(type: "text", nullable: false),
                    agency_description = table.Column<string>(type: "text", nullable: true),
                    location = table.Column<string>(type: "text", nullable: true),
                    test_drive = table.Column<bool>(type: "boolean", nullable: false),
                    layaway_system = table.Column<bool>(type: "boolean", nullable: false),
                    services = table.Column<bool>(type: "boolean", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agencies", x => x.agencyId);
                });

            migrationBuilder.CreateTable(
                name: "cat_email_type",
                columns: table => new
                {
                    emailTypeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    listTo = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cat_email_type", x => x.emailTypeId);
                });

            migrationBuilder.CreateTable(
                name: "cat_status",
                columns: table => new
                {
                    catStatusId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    description = table.Column<string>(type: "text", nullable: false),
                    isActive = table.Column<bool>(type: "boolean", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cat_status", x => x.catStatusId);
                });

            migrationBuilder.CreateTable(
                name: "cat_user_type",
                columns: table => new
                {
                    userTypeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_type = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cat_user_type", x => x.userTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    categoryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    category_name = table.Column<string>(type: "text", nullable: false),
                    category_description = table.Column<string>(type: "text", nullable: true),
                    category_image = table.Column<string>(type: "text", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.categoryId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    contactId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    cellPhone = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    coments = table.Column<string>(type: "text", nullable: false),
                    active = table.Column<bool>(type: "boolean", nullable: false),
                    createdDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.contactId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    countryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    countryName = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.countryId);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    modelId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    model_name = table.Column<string>(type: "text", nullable: false),
                    model_description = table.Column<string>(type: "text", nullable: true),
                    model_image = table.Column<string>(type: "text", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.modelId);
                });

            migrationBuilder.CreateTable(
                name: "Neighborhoods",
                columns: table => new
                {
                    neightborhoodId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    neightborhoodName = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Neighborhoods", x => x.neightborhoodId);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    stateId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    stateName = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.stateId);
                });

            migrationBuilder.CreateTable(
                name: "ZipCode",
                columns: table => new
                {
                    zipCodeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    zipCode = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZipCode", x => x.zipCodeId);
                });

            migrationBuilder.CreateTable(
                name: "email_template",
                columns: table => new
                {
                    emailTemplateId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    emailTypeId = table.Column<int>(type: "integer", nullable: false),
                    emailName = table.Column<string>(type: "text", nullable: true),
                    subject = table.Column<string>(type: "text", nullable: true),
                    template = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_email_template", x => x.emailTemplateId);
                    table.ForeignKey(
                        name: "FK_email_template_cat_email_type_emailTypeId",
                        column: x => x.emailTypeId,
                        principalTable: "cat_email_type",
                        principalColumn: "emailTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<Guid>(type: "uuid", nullable: false),
                    user_name = table.Column<string>(type: "text", nullable: false),
                    userTypeId = table.Column<int>(type: "integer", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userId);
                    table.ForeignKey(
                        name: "FK_Users_cat_user_type_userTypeId",
                        column: x => x.userTypeId,
                        principalTable: "cat_user_type",
                        principalColumn: "userTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    carId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    categoryId = table.Column<int>(type: "integer", nullable: false),
                    car_slug = table.Column<string>(type: "text", nullable: false),
                    car_name = table.Column<string>(type: "text", nullable: false),
                    shor_description = table.Column<string>(type: "text", nullable: true),
                    general_description = table.Column<string>(type: "text", nullable: true),
                    galery_general_description = table.Column<string>(type: "text", nullable: true),
                    force = table.Column<string>(type: "text", nullable: true),
                    force_galery = table.Column<string>(type: "text", nullable: true),
                    confort = table.Column<string>(type: "text", nullable: true),
                    confort_galery = table.Column<string>(type: "text", nullable: true),
                    smart = table.Column<string>(type: "text", nullable: true),
                    smart_gaery = table.Column<string>(type: "text", nullable: true),
                    security = table.Column<string>(type: "text", nullable: true),
                    security_galery = table.Column<string>(type: "text", nullable: true),
                    myth = table.Column<string>(type: "text", nullable: true),
                    myth_galery = table.Column<string>(type: "text", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.carId);
                    table.ForeignKey(
                        name: "FK_Cars_Categories_categoryId",
                        column: x => x.categoryId,
                        principalTable: "Categories",
                        principalColumn: "categoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryModel",
                columns: table => new
                {
                    CategoriescategoryId = table.Column<int>(type: "integer", nullable: false),
                    ModelsmodelId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryModel", x => new { x.CategoriescategoryId, x.ModelsmodelId });
                    table.ForeignKey(
                        name: "FK_CategoryModel_Categories_CategoriescategoryId",
                        column: x => x.CategoriescategoryId,
                        principalTable: "Categories",
                        principalColumn: "categoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryModel_Models_ModelsmodelId",
                        column: x => x.ModelsmodelId,
                        principalTable: "Models",
                        principalColumn: "modelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CountryNeighborhood",
                columns: table => new
                {
                    CountriescountryId = table.Column<int>(type: "integer", nullable: false),
                    NeighborhoodsneightborhoodId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryNeighborhood", x => new { x.CountriescountryId, x.NeighborhoodsneightborhoodId });
                    table.ForeignKey(
                        name: "FK_CountryNeighborhood_Countries_CountriescountryId",
                        column: x => x.CountriescountryId,
                        principalTable: "Countries",
                        principalColumn: "countryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryNeighborhood_Neighborhoods_Neighborhoodsneightborhoo~",
                        column: x => x.NeighborhoodsneightborhoodId,
                        principalTable: "Neighborhoods",
                        principalColumn: "neightborhoodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CountryState",
                columns: table => new
                {
                    CountriescountryId = table.Column<int>(type: "integer", nullable: false),
                    StatesstateId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryState", x => new { x.CountriescountryId, x.StatesstateId });
                    table.ForeignKey(
                        name: "FK_CountryState_Countries_CountriescountryId",
                        column: x => x.CountriescountryId,
                        principalTable: "Countries",
                        principalColumn: "countryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryState_States_StatesstateId",
                        column: x => x.StatesstateId,
                        principalTable: "States",
                        principalColumn: "stateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NeighborhoodZipCode",
                columns: table => new
                {
                    NeighborhoodsneightborhoodId = table.Column<int>(type: "integer", nullable: false),
                    ZipCodeszipCodeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NeighborhoodZipCode", x => new { x.NeighborhoodsneightborhoodId, x.ZipCodeszipCodeId });
                    table.ForeignKey(
                        name: "FK_NeighborhoodZipCode_Neighborhoods_Neighborhoodsneightborhoo~",
                        column: x => x.NeighborhoodsneightborhoodId,
                        principalTable: "Neighborhoods",
                        principalColumn: "neightborhoodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NeighborhoodZipCode_ZipCode_ZipCodeszipCodeId",
                        column: x => x.ZipCodeszipCodeId,
                        principalTable: "ZipCode",
                        principalColumn: "zipCodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_info",
                columns: table => new
                {
                    userInfoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user = table.Column<Guid>(type: "uuid", nullable: false),
                    agencyId = table.Column<int>(type: "integer", nullable: true),
                    name = table.Column<string>(type: "text", nullable: false),
                    birthday = table.Column<DateOnly>(type: "date", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    cell_phone = table.Column<string>(type: "text", nullable: false),
                    address = table.Column<string>(type: "text", nullable: false),
                    state = table.Column<string>(type: "text", nullable: false),
                    zipcode = table.Column<string>(type: "text", nullable: false),
                    country = table.Column<string>(type: "text", nullable: false),
                    neighborhood = table.Column<string>(type: "text", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_info", x => x.userInfoId);
                    table.ForeignKey(
                        name: "FK_user_info_Users_user",
                        column: x => x.user,
                        principalTable: "Users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "agency_car",
                columns: table => new
                {
                    agencyCarId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    carId = table.Column<int>(type: "integer", nullable: false),
                    agencyId = table.Column<int>(type: "integer", nullable: false),
                    test_drive = table.Column<bool>(type: "boolean", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_agency_car", x => x.agencyCarId);
                    table.ForeignKey(
                        name: "FK_agency_car_Agencies_agencyId",
                        column: x => x.agencyId,
                        principalTable: "Agencies",
                        principalColumn: "agencyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_agency_car_Cars_carId",
                        column: x => x.carId,
                        principalTable: "Cars",
                        principalColumn: "carId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Layaway",
                columns: table => new
                {
                    layawayId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    userId = table.Column<Guid>(type: "uuid", nullable: false),
                    agencyId = table.Column<int>(type: "integer", nullable: false),
                    carId = table.Column<int>(type: "integer", nullable: false),
                    amount = table.Column<double>(type: "double precision", nullable: false),
                    folio = table.Column<string>(type: "text", nullable: false),
                    comments = table.Column<string>(type: "text", nullable: true),
                    catStatusId = table.Column<int>(type: "integer", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Layaway", x => x.layawayId);
                    table.ForeignKey(
                        name: "FK_Layaway_Agencies_agencyId",
                        column: x => x.agencyId,
                        principalTable: "Agencies",
                        principalColumn: "agencyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Layaway_Cars_carId",
                        column: x => x.carId,
                        principalTable: "Cars",
                        principalColumn: "carId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Layaway_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Layaway_cat_status_catStatusId",
                        column: x => x.catStatusId,
                        principalTable: "cat_status",
                        principalColumn: "catStatusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    quotesId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    userId = table.Column<Guid>(type: "uuid", nullable: false),
                    agencyId = table.Column<int>(type: "integer", nullable: false),
                    carId = table.Column<int>(type: "integer", nullable: false),
                    folio = table.Column<string>(type: "text", nullable: false),
                    comments = table.Column<string>(type: "text", nullable: true),
                    catStatusId = table.Column<int>(type: "integer", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.quotesId);
                    table.ForeignKey(
                        name: "FK_Quotes_Agencies_agencyId",
                        column: x => x.agencyId,
                        principalTable: "Agencies",
                        principalColumn: "agencyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Quotes_Cars_carId",
                        column: x => x.carId,
                        principalTable: "Cars",
                        principalColumn: "carId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Quotes_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Quotes_cat_status_catStatusId",
                        column: x => x.catStatusId,
                        principalTable: "cat_status",
                        principalColumn: "catStatusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "services_schedule",
                columns: table => new
                {
                    servicesScheduleId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    userId = table.Column<Guid>(type: "uuid", nullable: false),
                    agencyId = table.Column<int>(type: "integer", nullable: false),
                    model_year = table.Column<int>(type: "integer", nullable: false),
                    carId = table.Column<int>(type: "integer", nullable: false),
                    schedule = table.Column<DateOnly>(type: "date", nullable: false),
                    kilometers = table.Column<int>(type: "integer", nullable: false),
                    comments = table.Column<string>(type: "text", nullable: true),
                    catStatusId = table.Column<int>(type: "integer", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_services_schedule", x => x.servicesScheduleId);
                    table.ForeignKey(
                        name: "FK_services_schedule_Agencies_agencyId",
                        column: x => x.agencyId,
                        principalTable: "Agencies",
                        principalColumn: "agencyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_services_schedule_Cars_carId",
                        column: x => x.carId,
                        principalTable: "Cars",
                        principalColumn: "carId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_services_schedule_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_services_schedule_cat_status_catStatusId",
                        column: x => x.catStatusId,
                        principalTable: "cat_status",
                        principalColumn: "catStatusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "setting_car",
                columns: table => new
                {
                    settingCarId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    carId = table.Column<int>(type: "integer", nullable: false),
                    setting_car_name = table.Column<string>(type: "text", nullable: true),
                    price = table.Column<double>(type: "double precision", nullable: false),
                    parameter_settings = table.Column<string>(type: "text", nullable: false),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_setting_car", x => x.settingCarId);
                    table.ForeignKey(
                        name: "FK_setting_car_Cars_carId",
                        column: x => x.carId,
                        principalTable: "Cars",
                        principalColumn: "carId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "test_drive_schedule",
                columns: table => new
                {
                    testDriveScheduleId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    userId = table.Column<Guid>(type: "uuid", nullable: false),
                    agencyId = table.Column<int>(type: "integer", nullable: false),
                    model_year = table.Column<int>(type: "integer", nullable: false),
                    carId = table.Column<int>(type: "integer", nullable: false),
                    schedule = table.Column<DateOnly>(type: "date", nullable: false),
                    comments = table.Column<string>(type: "text", nullable: true),
                    catStatusId = table.Column<int>(type: "integer", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_test_drive_schedule", x => x.testDriveScheduleId);
                    table.ForeignKey(
                        name: "FK_test_drive_schedule_Agencies_agencyId",
                        column: x => x.agencyId,
                        principalTable: "Agencies",
                        principalColumn: "agencyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_test_drive_schedule_Cars_carId",
                        column: x => x.carId,
                        principalTable: "Cars",
                        principalColumn: "carId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_test_drive_schedule_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_test_drive_schedule_cat_status_catStatusId",
                        column: x => x.catStatusId,
                        principalTable: "cat_status",
                        principalColumn: "catStatusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    inventoryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    agencyCar = table.Column<int>(type: "integer", nullable: false),
                    count_test_drive = table.Column<int>(type: "integer", nullable: false),
                    count_layaway = table.Column<int>(type: "integer", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.inventoryId);
                    table.ForeignKey(
                        name: "FK_Inventories_agency_car_agencyCar",
                        column: x => x.agencyCar,
                        principalTable: "agency_car",
                        principalColumn: "agencyCarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_agency_car_agencyId",
                table: "agency_car",
                column: "agencyId");

            migrationBuilder.CreateIndex(
                name: "IX_agency_car_carId",
                table: "agency_car",
                column: "carId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_categoryId",
                table: "Cars",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryModel_ModelsmodelId",
                table: "CategoryModel",
                column: "ModelsmodelId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryNeighborhood_NeighborhoodsneightborhoodId",
                table: "CountryNeighborhood",
                column: "NeighborhoodsneightborhoodId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryState_StatesstateId",
                table: "CountryState",
                column: "StatesstateId");

            migrationBuilder.CreateIndex(
                name: "IX_email_template_emailTypeId",
                table: "email_template",
                column: "emailTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_agencyCar",
                table: "Inventories",
                column: "agencyCar",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Layaway_agencyId",
                table: "Layaway",
                column: "agencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Layaway_carId",
                table: "Layaway",
                column: "carId");

            migrationBuilder.CreateIndex(
                name: "IX_Layaway_catStatusId",
                table: "Layaway",
                column: "catStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Layaway_userId",
                table: "Layaway",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_NeighborhoodZipCode_ZipCodeszipCodeId",
                table: "NeighborhoodZipCode",
                column: "ZipCodeszipCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_agencyId",
                table: "Quotes",
                column: "agencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_carId",
                table: "Quotes",
                column: "carId");

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_catStatusId",
                table: "Quotes",
                column: "catStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_userId",
                table: "Quotes",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_services_schedule_agencyId",
                table: "services_schedule",
                column: "agencyId");

            migrationBuilder.CreateIndex(
                name: "IX_services_schedule_carId",
                table: "services_schedule",
                column: "carId");

            migrationBuilder.CreateIndex(
                name: "IX_services_schedule_catStatusId",
                table: "services_schedule",
                column: "catStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_services_schedule_userId",
                table: "services_schedule",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_setting_car_carId",
                table: "setting_car",
                column: "carId");

            migrationBuilder.CreateIndex(
                name: "IX_test_drive_schedule_agencyId",
                table: "test_drive_schedule",
                column: "agencyId");

            migrationBuilder.CreateIndex(
                name: "IX_test_drive_schedule_carId",
                table: "test_drive_schedule",
                column: "carId");

            migrationBuilder.CreateIndex(
                name: "IX_test_drive_schedule_catStatusId",
                table: "test_drive_schedule",
                column: "catStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_test_drive_schedule_userId",
                table: "test_drive_schedule",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_user_info_user",
                table: "user_info",
                column: "user",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_userTypeId",
                table: "Users",
                column: "userTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryModel");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "CountryNeighborhood");

            migrationBuilder.DropTable(
                name: "CountryState");

            migrationBuilder.DropTable(
                name: "email_template");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "Layaway");

            migrationBuilder.DropTable(
                name: "NeighborhoodZipCode");

            migrationBuilder.DropTable(
                name: "Quotes");

            migrationBuilder.DropTable(
                name: "services_schedule");

            migrationBuilder.DropTable(
                name: "setting_car");

            migrationBuilder.DropTable(
                name: "test_drive_schedule");

            migrationBuilder.DropTable(
                name: "user_info");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "cat_email_type");

            migrationBuilder.DropTable(
                name: "agency_car");

            migrationBuilder.DropTable(
                name: "Neighborhoods");

            migrationBuilder.DropTable(
                name: "ZipCode");

            migrationBuilder.DropTable(
                name: "cat_status");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Agencies");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "cat_user_type");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
