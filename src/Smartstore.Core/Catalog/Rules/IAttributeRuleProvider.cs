﻿#nullable enable

using Smartstore.Core.Catalog.Attributes;
using Smartstore.Core.Catalog.Products;
using Smartstore.Core.Rules;

namespace Smartstore.Core.Catalog.Rules
{
    /// <summary>
    /// Represents a product attribute rule provider (conditional attributes).
    /// </summary>
    public partial interface IAttributeRuleProvider : IRuleProvider
    {
        /// <summary>
        /// Gets the rule processor.
        /// </summary>
        /// <param name="expression">Rule expression.</param>
        /// <returns>Rule processor.</returns>
        IRule<AttributeRuleContext> GetProcessor(RuleExpression expression);

        /// <summary>
        /// Creates a rule expression group for a <see cref="ProductVariantAttribute"/>.
        /// </summary>
        /// <param name="includeHidden">A value indicating whether to include hidden rulesets.</param>
        Task<IRuleExpressionGroup> CreateExpressionGroupAsync(ProductVariantAttribute attribute, bool includeHidden = false);

        /// <summary>
        /// Checks whether <see cref="ProductVariantAttribute"/> is active (whether the assigned rule is met).
        /// </summary>
        /// <param name="context">Attribute rule context.</param>
        /// <param name="logicalOperator">Rule operator.</param>
        /// <returns><c>true</c> the attribute is active, otherwise <c>false</c>.</returns>
        Task<bool> IsAttributeActiveAsync(AttributeRuleContext context, LogicalRuleOperator logicalOperator = LogicalRuleOperator.And);
    }


    /// <summary>
    /// Context object provided when instantiating <see cref="IAttributeRuleProvider"/>.
    /// Only required in case of <see cref="IAttributeRuleProvider"/> at the moment.
    /// </summary>
    public partial class AttributeRuleProviderContext(int productId)
    {
        public int ProductId { get; } = Guard.NotZero(productId);
        public List<ProductVariantAttribute>? Attributes { get; init; }
        public ProductBatchContext? BatchContext { get; init; }
    }
}
